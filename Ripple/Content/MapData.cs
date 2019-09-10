using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ripple.BIN;
using Ripple.BIN.Classes;

namespace Ripple.Content
{
    public class MapData
    {
        public Entry<MapContainer> Container { get; set; }
        public List<Entry<Class_2992376383>> Chunks { get; set; } = new List<Entry<Class_2992376383>>();
        public List<Entry<StaticMaterialDef>> StaticMaterials { get; set; } = new List<Entry<StaticMaterialDef>>();
        public List<Entry<MapPointLightType>> PointLightTypes { get; set; } = new List<Entry<MapPointLightType>>();

        public MapData(Dictionary<uint, object> serialized)
        {
            SetMapContainer(serialized);
            SetChunks(serialized);
            SetStaticMaterials(serialized);
            SetPointLightTypes(serialized);
        }

        private void SetMapContainer(Dictionary<uint, object> serialized)
        {
            IEnumerable<KeyValuePair<uint, object>> containers = serialized.Where(x => x.Value.GetType() == typeof(MapContainer));

            if(containers.Count() != 1)
            {
                throw new Exception("Invalid amount of Map Containers in Map BIN File: " + containers.Count());
            }
            else
            {
                this.Container = new Entry<MapContainer>(containers.First().Key, containers.First().Value as MapContainer);
            }
        }
        private void SetChunks(Dictionary<uint, object> serialized)
        {
            foreach(KeyValuePair<Hash, Link<Class_2992376383>> chunkLink in this.Container.Class.m1577983395)
            {
                this.Chunks.Add(new Entry<Class_2992376383>(chunkLink.Value, (Class_2992376383)serialized[chunkLink.Value]));
            }
        }

        private void SetStaticMaterials(Dictionary<uint, object> serialized)
        {
            foreach(KeyValuePair<uint, object> staticMaterial in serialized.Where(x => x.Value.GetType() == typeof(StaticMaterialDef)))
            {
                this.StaticMaterials.Add(new Entry<StaticMaterialDef>(staticMaterial.Key, staticMaterial.Value as StaticMaterialDef));
            }
        }

        private void SetPointLightTypes(Dictionary<uint, object> serialized)
        {
            foreach (KeyValuePair<uint, object> pointLightType in serialized.Where(x => x.Value.GetType() == typeof(MapPointLightType)))
            {
                this.PointLightTypes.Add(new Entry<MapPointLightType>(pointLightType.Key, pointLightType.Value as MapPointLightType));
            }
        }
    }
}
