using Fantome.Libraries.League.IO.MapGeometry;
using HelixToolkit.Wpf.SharpDX;
using HelixToolkit.Wpf.SharpDX.Model.Scene;
using Imaging.DDSReader;
using Microsoft.Win32;
using Ripple.BIN;
using Ripple.Content;
using Ripple.MVVM.Commands;
using Ripple.MVVM.ViewModels;
using Ripple.Utilities;
using SharpDX;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using mPoint3D = System.Windows.Media.Media3D.Point3D;
using mVector3D = System.Windows.Media.Media3D.Vector3D;

namespace Ripple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ViewportViewModel ViewportViewModel => this.Viewport.DataContext as ViewportViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            BindMVVM();
        }

        private void BindMVVM()
        {
            InitializeViewport();
        }
        private void InitializeViewport()
        {
            this.Viewport.DataContext = new ViewportViewModel();
        }        

        private void OnOpenMap(object sender, RoutedEventArgs e)
        {
            OpenMap();
        }
        private async void OpenMap()
        {
            await DialogHelper.ShowOpenMapDialog(this.ViewportViewModel);
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

