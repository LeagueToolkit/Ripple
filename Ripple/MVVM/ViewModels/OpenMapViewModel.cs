using Fantome.Libraries.League.IO.BIN;
using Fantome.Libraries.League.IO.MapGeometry;
using HelixToolkit.Wpf.SharpDX;
using HelixToolkit.Wpf.SharpDX.Model.Scene;
using Microsoft.WindowsAPICodePack.Dialogs;
using Ripple.BIN;
using Ripple.Content;
using Ripple.MVVM.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ripple.MVVM.ViewModels
{
    public class OpenMapViewModel : INotifyPropertyChanged
    {
        public string MapRootLocation
        {
            get => this._mapRootLocation;
            set
            {
                this._mapRootLocation = value;
                NotifyPropertyChanged();
            }
        }
        public string MapGeometryLocation
        {
            get => this._mapGeometryLocation;
            set
            {
                this._mapGeometryLocation = value;
                NotifyPropertyChanged();
            }
        }
        public string MaterialsBinLocation
        {
            get => this._materialsBinLocation;
            set
            {
                this._materialsBinLocation = value;
                NotifyPropertyChanged();
            }
        }

        private string _mapRootLocation;
        private string _mapGeometryLocation;
        private string _materialsBinLocation;

        private ViewportViewModel _viewport;

        public ICommand SelectMapRootCommand => new RelayCommand(SelectMapRoot);
        public ICommand SelectMapGeometryCommand => new RelayCommand(SelectMapGeometry);
        public ICommand SelectMaterialsBinCommand => new RelayCommand(SelectMaterialsBin);

        public event PropertyChangedEventHandler PropertyChanged;

        public OpenMapViewModel(ViewportViewModel viewport)
        {
            this._viewport = viewport;
        }

        public void Load()
        {
            MGEOFile mapGeometry = new MGEOFile(this._mapGeometryLocation);
            MapData mapData = new MapData(BINSerializer.Serialize(new BINFile(this._materialsBinLocation)));
            IEnumerable<GroupNode> mapGeometryObjects = ContentLoader.LoadMapMGEO(mapGeometry, mapData, this._mapRootLocation);

            SceneNodeGroupModel3D mainModelGroup = new SceneNodeGroupModel3D();
            foreach (GroupNode mapGeometryObject in mapGeometryObjects)
            {
                mainModelGroup.AddNode(mapGeometryObject);
            }

            this._viewport.MainModelGroup = mainModelGroup;
        }

        private void SelectMapRoot(object o)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog("Select the Map Root") { IsFolderPicker = true })
            {
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    this.MapRootLocation = dialog.FileName;
                }
            }
        }
        private void SelectMapGeometry(object o)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog("Select the Map Geometry File") { Multiselect = false })
            {
                dialog.Filters.Add(new CommonFileDialogFilter("Map Geometry Files", ".mapgeo"));

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    this.MapGeometryLocation = dialog.FileName;
                }
            }
        }
        private void SelectMaterialsBin(object o)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog("Select the Materials BIN File") { Multiselect = false })
            {
                dialog.Filters.Add(new CommonFileDialogFilter("Materials BIN Files", ".bin"));

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    this.MaterialsBinLocation = dialog.FileName;
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
