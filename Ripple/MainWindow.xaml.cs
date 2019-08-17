using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Fantome.Libraries.League.IO.WorldGeometry;
using HelixToolkit.Wpf.SharpDX.Core;
using System.IO;
using Imaging.DDSReader;
using System.Drawing.Imaging;
using Microsoft.Win32;
using HelixToolkit.Wpf.SharpDX.Render;
using HelixToolkit.Wpf.SharpDX;

using mPoint3D = System.Windows.Media.Media3D.Point3D;
using mVector3D = System.Windows.Media.Media3D.Vector3D;
using dxPoint3D = SharpDX.Point;
using HelixToolkit.Wpf.SharpDX.Model.Scene;
using Fantome.Libraries.League.IO.MapGeometry;
using SharpDX;

namespace Ripple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SceneNodeGroupModel3D MainModelGroup { get; set; } = new SceneNodeGroupModel3D();
        public DefaultEffectsManager EffectsManager { get; set; }
        public PerspectiveCamera Camera { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.EffectsManager = new DefaultEffectsManager();
            this.Camera = CreateCamera();
            this.Viewport.DataContext = this;

        }
            

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Map Geometry files (*.mapgeo)|*.mapgeo";

            if (dialog.ShowDialog() == true)
            {
                LoadMGEO(dialog.FileName);
            }


        }

        public void LoadMGEO(string fileLocation)
        {
            MGEOFile mgeo = new MGEOFile(fileLocation);
            List<MeshGeometryModel3D> meshGeometryModels = GenerateMeshGeometryModels(mgeo);
            /*elements.Add(new DirectionalLight3D()
            {
                Direction = new Vector3(0, -1, -0.5f),
                Color = new Color4(1, 1, 1, 1)
            });
            elements.Add(new AmbientLight3D()
            {
                Color = new Color(0.64705882352f, 0.64705882352f, 0.64705882352f, 1)
            });*/

            foreach(MeshGeometryModel3D meshGeometryModel in meshGeometryModels)
            {
                GroupNode groupNode = new GroupNode()
                {
                    Name = meshGeometryModel.Name
                };

                groupNode.AddChildNode(new MeshNode()
                {
                    Name = meshGeometryModel.Name,
                    Geometry = meshGeometryModel.Geometry,
                    Material = meshGeometryModel.Material
                });

                this.MainModelGroup.AddNode(groupNode);
            }
        }

        public List<MeshGeometryModel3D> GenerateMeshGeometryModels(MGEOFile mgeo)
        {
            List<MeshGeometryModel3D> models = new List<MeshGeometryModel3D>(mgeo.Objects.Count);

            foreach (MGEOObject mgeoModel in mgeo.Objects)
            {
                MeshGeometry3D meshGeometry = new MeshGeometry3D();

                IntCollection indices = new IntCollection(mgeoModel.Indices.Select(x => (int)x).AsEnumerable());
                Vector3Collection vertices = new Vector3Collection(mgeoModel.Vertices.Count);
                Vector2Collection uvs = new Vector2Collection(mgeoModel.Vertices.Count);
                foreach (MGEOVertex vertex in mgeoModel.Vertices)
                {
                    vertices.Add(new Vector3(vertex.Position.X, vertex.Position.Y, vertex.Position.Z));
                    uvs.Add(new Vector2(vertex.DiffuseUV.X, vertex.DiffuseUV.Y));
                }

                meshGeometry.Indices = indices;
                meshGeometry.Positions = vertices;
                meshGeometry.TextureCoordinates = uvs;

                MeshGeometryModel3D model = new MeshGeometryModel3D();
                model.Geometry = meshGeometry;
                model.Material = PhongMaterials.Blue;
                model.Name = mgeoModel.Name;

                models.Add(model);
            }

            return models;
        }

        private MemoryStream DDSToImage(string fileLocation)
        {
            MemoryStream ms = new MemoryStream();
            DDS.LoadImage("textures/4x_" + fileLocation).Save(ms, ImageFormat.Png);

            return ms;

        }

        private PerspectiveCamera CreateCamera()
        {
            return new PerspectiveCamera()
            {
                Position = new mPoint3D(0, 0, 5),
                LookDirection = new mVector3D(-0, -0, -5),
                UpDirection = new mVector3D(0, 1, 0),
                NearPlaneDistance = 0.5,
                FarPlaneDistance = 10000000
            };
        }
    } 
}

