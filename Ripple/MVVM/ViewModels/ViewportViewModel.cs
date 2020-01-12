using HelixToolkit.Wpf.SharpDX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using mPoint3D = System.Windows.Media.Media3D.Point3D;
using mVector3D = System.Windows.Media.Media3D.Vector3D;

namespace Ripple.MVVM.ViewModels
{
    public class ViewportViewModel : INotifyPropertyChanged
    {
        public PerspectiveCamera Camera
        {
            get => this._camera;
            set
            {
                this._camera = value;
                NotifyPropertyChanged();
            }
        }
        public EffectsManager EffectsManager
        {
            get => this._effectsManager;
            set
            {
                this._effectsManager = value;
                NotifyPropertyChanged();
            }
        }
        public SceneNodeGroupModel3D MainModelGroup
        {
            get => this._mainModelGroup;
            set
            {
                this._mainModelGroup = value;
                NotifyPropertyChanged();
            }
        }

        private PerspectiveCamera _camera;
        private EffectsManager _effectsManager;
        private SceneNodeGroupModel3D _mainModelGroup;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewportViewModel()
        {
            this.Camera = CreateCamera();
            this.EffectsManager = CreateEffectsManager();
            this._mainModelGroup = new SceneNodeGroupModel3D();
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
        private EffectsManager CreateEffectsManager()
        {
            return new DefaultEffectsManager();
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
