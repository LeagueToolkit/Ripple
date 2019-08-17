using Fantome.Libraries.League.IO.MapGeometry;
using HelixToolkit.Wpf.SharpDX;
using HelixToolkit.Wpf.SharpDX.Model.Scene;
using Imaging.DDSReader;
using Microsoft.Win32;
using SharpDX;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows;

using mPoint3D = System.Windows.Media.Media3D.Point3D;
using mVector3D = System.Windows.Media.Media3D.Vector3D;

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
                LoadMapMGEO(dialog.FileName);
            }


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

