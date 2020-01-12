using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fantome.Libraries.League.IO.BIN;
using Fantome.Libraries.League.IO.MapGeometry;
using HelixToolkit.Wpf.SharpDX;
using HelixToolkit.Wpf.SharpDX.Model.Scene;
using Imaging.DDSReader;
using SharpDX;

using mPoint3D = System.Windows.Media.Media3D.Point3D;
using mVector3D = System.Windows.Media.Media3D.Vector3D;
using dxVector3 = SharpDX.Vector3;
using dxVector2 = SharpDX.Vector2;
using Ripple.BIN;
using Ripple.BIN.Classes;

namespace Ripple.Content
{
    public static class ContentLoader
    {
        public static IEnumerable<GroupNode> LoadMapMGEO(string fileLocation, MapData mapData, string mapPath)
        {
            return LoadMapMGEO(new MGEOFile(fileLocation), mapData, mapPath);
        }

        public static IEnumerable<GroupNode> LoadMapMGEO(MGEOFile mgeo, MapData mapData, string mapPath)
        {
            foreach (MGEOObject mgeoModel in mgeo.Objects)
            {
                IntCollection indices = new IntCollection(mgeoModel.Indices.Select(x => (int)x).AsEnumerable());
                Vector3Collection vertices = new Vector3Collection(mgeoModel.Vertices.Count);
                Vector2Collection uvs = new Vector2Collection(mgeoModel.Vertices.Count);
                foreach (MGEOVertex vertex in mgeoModel.Vertices)
                {
                    vertices.Add(new dxVector3(vertex.Position.X, vertex.Position.Y, vertex.Position.Z));
                    uvs.Add(new dxVector2(vertex.DiffuseUV.X, vertex.DiffuseUV.Y));
                }

                foreach (MGEOSubmesh submesh in mgeoModel.Submeshes)
                {
                    GroupNode groupNode = new GroupNode()
                    {
                        Name = mgeoModel.Name
                    };

                    MeshGeometry3D submeshGeometry3D = new MeshGeometry3D()
                    {
                        Indices = indices.GetRange((int)submesh.StartIndex, (int)submesh.IndexCount) as IntCollection,
                        Positions = vertices,
                        TextureCoordinates = uvs
                    };

                    DiffuseMaterial diffuseMaterial = new DiffuseMaterial()
                    {
                        Name = submesh.Material,
                        DiffuseMap = CreateMaterial(submesh.Material, mapData, mapPath),
                        EnableUnLit = true
                    };

                    groupNode.AddChildNode(new MeshNode()
                    {
                        Name = mgeoModel.Name + "|" + submesh.Material,
                        Geometry = submeshGeometry3D,
                        Material = diffuseMaterial
                    });

                    yield return groupNode;
                }
            }
        }

        private static TextureModel CreateMaterial(string materialName, MapData mapData, string mapPath)
        {
            object kek = mapData.StaticMaterials.Find(x => x.Class.Name == materialName);
            StaticMaterialDef staticMaterialDef = mapData.StaticMaterials.Find(x => x.Class.Name == materialName);
            StaticMaterialShaderSamplerDef shaderSampler = staticMaterialDef.SamplerValues.Find(x => x.SamplerName.Contains("Diffuse"));

            return new TextureModel(File.OpenRead(Path.Combine(mapPath, shaderSampler.TextureName)));
        }

        public static Dictionary<uint, object> LoadMapBIN(string fileLocation)
        {
            BINFile bin = new BINFile(fileLocation);
            return BINSerializer.Serialize(bin);
        }

        public static MemoryStream DDSToImage(string fileLocation)
        {
            return DDSToImage(File.ReadAllBytes(fileLocation));
        }

        public static MemoryStream DDSToImage(byte[] dds)
        {
            MemoryStream ms = new MemoryStream();
            DDS.LoadImage(dds).Save(ms, ImageFormat.Png);

            return ms;
        }
    }
}
