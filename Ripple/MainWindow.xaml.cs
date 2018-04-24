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
using HelixToolkit.Wpf.SharpDX;
using Fantome.Libraries.League.IO.WorldGeometry;
using HelixToolkit.Wpf.SharpDX.Core;
using System.IO;
using Imaging.DDSReader;
using System.Drawing.Imaging;
using Microsoft.Win32;

namespace Ripple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEffectsManager EffectsManager { get; set; }
        public RenderTechnique RenderTechnique { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            (this.Viewport.Camera as ProjectionCamera).FarPlaneDistance = 100000;
            this.Viewport.EffectsManager = new DefaultEffectsManager(new DefaultRenderTechniquesManager());
            this.Viewport.RenderTechnique = this.Viewport.EffectsManager.RenderTechniquesManager.RenderTechniques[DefaultRenderTechniqueNames.Diffuse];

            TestLoadWGEO("room.wgeo");
        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "World Geometry files (*.wgeo)|*.wgeo";

            if(dialog.ShowDialog() == true)
            {
                TestLoadWGEO(dialog.FileName);
            }
        }

        public void TestLoadWGEO(string fileLocation)
        {
            WGEOFile wgeo = new WGEOFile(fileLocation);
            List<Element3D> elements = GenerateMeshGeometryModels(wgeo.Models);
            elements.Add(new DirectionalLight3D()
            {
                Direction = new SharpDX.Vector3(0, -1, -0.5f),
                Color = new SharpDX.Color4(1, 1, 1, 1)
            });
            elements.Add(new AmbientLight3D()
            {
                Color = new SharpDX.Color4(0.64705882352f, 0.64705882352f, 0.64705882352f, 1)
            });

            this.Viewport.ItemsSource = elements;
        }

        public List<Element3D> GenerateMeshGeometryModels(List<WGEOModel> meshes)
        {
            List<Element3D> models = new List<Element3D>(meshes.Count);

            foreach (WGEOModel mesh in meshes)
            {
                MeshGeometry3D meshGeometry = new MeshGeometry3D();

                IntCollection indices = new IntCollection(mesh.Indices.Select(x => (int)x).AsEnumerable());
                Vector3Collection vertices = new Vector3Collection(mesh.Vertices.Count);
                Vector2Collection uvs = new Vector2Collection(mesh.Vertices.Count);
                foreach (WGEOVertex vertex in mesh.Vertices)
                {
                    vertices.Add(new SharpDX.Vector3(vertex.Position.X, vertex.Position.Y, vertex.Position.Z));
                    uvs.Add(new SharpDX.Vector2(vertex.UV.X, vertex.UV.Y));
                }

                meshGeometry.Indices = indices;
                meshGeometry.Positions = vertices;
                meshGeometry.TextureCoordinates = uvs;

                MeshGeometryModel3D model = new MeshGeometryModel3D();
                model.Geometry = meshGeometry;
                try
                {
                    model.Material = new PhongMaterial()
                    {
                        DiffuseMap = DDSToImage(mesh.Texture)
                    };
                }
                catch (Exception)
                {
                    model.Material = PhongMaterials.Blue;
                }

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
    }
}
