using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Fantome.Libraries.League.Helpers.Cryptography;
using Fantome.Libraries.League.IO.BIN;

namespace Ripple.BIN
{
    public static class BINSerializer
    {
        private static Dictionary<uint, Type> _classMap;

        public static void RegisterClasses()
        {
            _classMap = new Dictionary<uint, Type>();

            foreach (Type classType in Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && x.Namespace == "Ripple.BIN.Classes"))
            {
                if(classType.Name.StartsWith("Class_"))
                {
                    uint hash = uint.Parse(classType.Name.Substring(6));
                    _classMap.Add(hash, classType);
                }
                else
                {
                    _classMap.Add(Cryptography.FNV32Hash(classType.Name), classType);
                }
            }
        }

        public static Dictionary<uint, object> Serialize(BINFile bin)
        {
            Dictionary<uint, object> serializedEntries = new Dictionary<uint, object>();

            if(_classMap == null)
            {
                RegisterClasses();
            }

            foreach(BINEntry entry in bin.Entries)
            {
                if(!_classMap.ContainsKey(entry.Class))
                {
                    continue;
                }
                else
                {
                    Type entryType = _classMap[entry.Class];
                    serializedEntries[entry.Property] = Serialize(entry.Values, entryType);
                }
            }

            return serializedEntries;
        }

        private static object Serialize(List<BINValue> values, Type type)
        {
            object constructedClass = Activator.CreateInstance(type);
            TypeInfo constructedClassInfo = constructedClass.GetType().GetTypeInfo();
            foreach (PropertyInfo propertyInfo in constructedClassInfo.GetProperties())
            {
                uint propertyHash = GetValueAttributeHash(propertyInfo);
                BINValue value = values.Find(x => x.Property == propertyHash);

                if(value != null)
                {
                    if (IsPrimitiveType(value.Type.Value))
                    {
                        propertyInfo.SetValue(constructedClass, value.Value);
                    }
                    else if(value.Type == BINValueType.Hash)
                    {
                        propertyInfo.SetValue(constructedClass, new Hash((uint)value.Value));
                    }
                    else if(value.Type == BINValueType.LinkOffset)
                    {
                        Type linkType = typeof(Link<>).MakeGenericType(propertyInfo.PropertyType.GenericTypeArguments[0]);
                        object link = Activator.CreateInstance(linkType, new object[] { (uint)value.Value });

                        propertyInfo.SetValue(constructedClass, link);
                    }
                    else if(value.Type == BINValueType.Optional)
                    {
                        Type optionalType = typeof(Optional<>).MakeGenericType(propertyInfo.PropertyType.GenericTypeArguments[0]);
                        object optional = Activator.CreateInstance(optionalType, new object[] { SerializeOptional(value, propertyInfo) });

                        propertyInfo.SetValue(constructedClass, optional);
                    }
                    else if(value.Type == BINValueType.Structure || value.Type == BINValueType.Embedded)
                    {
                        propertyInfo.SetValue(constructedClass, SerializeStructure(value));
                    }
                    else if(value.Type == BINValueType.Container)
                    {
                        propertyInfo.SetValue(constructedClass, SerializeContainer(value, propertyInfo));
                    }
                    else if(value.Type == BINValueType.Map)
                    {
                        propertyInfo.SetValue(constructedClass, SerializeMap(value, propertyInfo));
                    }
                }
            }


            return constructedClass;
        }

        private static object SerializeContainer(BINValue value, PropertyInfo propertyInfo)
        {
            BINContainer container = value.Value as BINContainer;
            object constructedList = Activator.CreateInstance(propertyInfo.PropertyType);
            TypeInfo constructedListInfo = constructedList.GetType().GetTypeInfo();

            if(IsPrimitiveType(container.EntryType))
            {
                foreach(BINValue containerValue in container.Values)
                {
                    constructedListInfo.GetMethod("Add").Invoke(constructedList, new[] { containerValue.Value });
                }
            }
            else if(container.EntryType == BINValueType.Embedded || container.EntryType == BINValueType.Structure)
            {
                foreach (BINValue containerValue in container.Values)
                {
                    constructedListInfo.GetMethod("Add").Invoke(constructedList, new[] { SerializeStructure(containerValue) });
                }
            }

            return constructedList;
        }

        private static object SerializeStructure(BINValue value)
        {
            BINStructure structure = value.Value as BINStructure;

            if(_classMap.ContainsKey(structure.Property))
            {
                return Serialize(structure.Values, _classMap[structure.Property]);
            }
            else
            {
                return null;
            }
        }

        private static object SerializeMap(BINValue value, PropertyInfo propertyInfo)
        {
            BINMap map = value.Value as BINMap;
            object constructedMap = Activator.CreateInstance(propertyInfo.PropertyType);
            TypeInfo constructedMapInfo = constructedMap.GetType().GetTypeInfo();

            foreach(KeyValuePair<BINValue, BINValue> pair in map.Values)
            {
                object pairKey = map.KeyType == BINValueType.Hash ? new Hash((uint)pair.Key.Value) : pair.Key.Value;
                object pairValue = null;

                if (IsPrimitiveType(map.ValueType))
                {
                    pairValue = pair.Value.Value;
                }
                else if (map.ValueType == BINValueType.Hash)
                {
                    pairValue = new Hash((uint)pair.Value.Value);
                }
                else if (map.ValueType == BINValueType.LinkOffset)
                {
                    Type linkType = propertyInfo.PropertyType.GenericTypeArguments[1];
                    pairValue = Activator.CreateInstance(linkType, new object[] { (uint)pair.Value.Value });
                }
                else if (map.ValueType == BINValueType.Structure || map.ValueType == BINValueType.Embedded)
                {
                    pairValue = SerializeStructure(pair.Value);
                }
                else if (map.ValueType == BINValueType.Container)
                {
                    pairValue = SerializeContainer(value, propertyInfo);
                }

                constructedMapInfo.GetMethod("Add").Invoke(constructedMap, new[] { pairKey, pairValue });
            }

            return constructedMap;
        }

        private static object SerializeOptional(BINValue value, PropertyInfo propertyInfo)
        {
            BINOptional optional = value.Value as BINOptional;
            object constructedOptional = null;

            if(optional.Value != null)
            {
                if (IsPrimitiveType(optional.Type))
                {
                    constructedOptional = optional.Value.Value;
                }
                else if (value.Type == BINValueType.Hash)
                {
                    constructedOptional = new Hash((uint)optional.Value.Value);
                }
                else if (value.Type == BINValueType.LinkOffset)
                {
                    Type linkType = typeof(Link<>).MakeGenericType(propertyInfo.PropertyType.GenericTypeArguments[0]);
                    constructedOptional = Activator.CreateInstance(linkType, new object[] { (uint)value.Value });
                }
                else if (value.Type == BINValueType.Structure || value.Type == BINValueType.Embedded)
                {
                    constructedOptional = SerializeStructure(optional.Value);
                }
                else if (value.Type == BINValueType.Container)
                {
                    constructedOptional = SerializeContainer(optional.Value, propertyInfo);
                }
                else if (value.Type == BINValueType.Map)
                {
                    constructedOptional = SerializeMap(optional.Value, propertyInfo);
                }
            }

            return constructedOptional;
        }

        private static uint GetValueAttributeHash(PropertyInfo propertyInfo)
        {
            BINValueAttribute valueAttribute = propertyInfo.GetCustomAttribute<BINValueAttribute>();
            TypeInfo valueAttributeType = propertyInfo.CustomAttributes.First().AttributeType.GetTypeInfo();
            PropertyInfo attributeHashInfo = valueAttributeType.GetProperty("Hash");
            return (uint)attributeHashInfo.GetValue(valueAttribute);
        }

        private static bool IsPrimitiveType(BINValueType type)
        {
            return type != BINValueType.Container && type != BINValueType.Embedded && type != BINValueType.Structure &&
                   type != BINValueType.LinkOffset && type != BINValueType.Map && type != BINValueType.Optional &&
                   type != BINValueType.Hash;

        }
    }
}