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

namespace Ripple.Content
{
    public static class ContentLoader
    {
        public static SceneNodeGroupModel3D LoadMapMGEO(string fileLocation)
        {
            return LoadMapMGEO(new MGEOFile(fileLocation));
        }

        public static SceneNodeGroupModel3D LoadMapMGEO(MGEOFile mgeo)
        {
            List<MeshGeometryModel3D> meshGeometryModels = GenerateMeshGeometryModels(mgeo);
            SceneNodeGroupModel3D mainModelGroup = new SceneNodeGroupModel3D();

            foreach (MeshGeometryModel3D meshGeometryModel in meshGeometryModels)
            {
                GroupNode groupNode = new GroupNode()
                {
                    Name = meshGeometryModel.Name
                };

                groupNode.AddChildNode(new MeshNode()
                {
                    Name = meshGeometryModel.Name,
                    Geometry = meshGeometryModel.Geometry,
                    Material = meshGeometryModel.Material,
                });

                mainModelGroup.AddNode(groupNode);
            }

            return mainModelGroup;
        }

        public static MapData LoadMapBIN(string fileLocation)
        {
            BINFile bin = new BINFile(fileLocation);
            Dictionary<Type, List<object>> serialized = BINSerializer.Serialize(bin);


            return new MapData();
        }



        private static List<MeshGeometryModel3D> GenerateMeshGeometryModels(MGEOFile mgeo)
        {
            List<MeshGeometryModel3D> models = new List<MeshGeometryModel3D>(mgeo.Objects.Count);

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

                MeshGeometry3D meshGeometry = new MeshGeometry3D()
                {
                    Indices = indices,
                    Positions = vertices,
                    TextureCoordinates = uvs
                };

                MeshGeometryModel3D model = new MeshGeometryModel3D()
                {
                    Geometry = meshGeometry,
                    Material = DiffuseMaterials.Pearl,
                    Name = mgeoModel.Name
                };

                models.Add(model);
            }

            return models;
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
