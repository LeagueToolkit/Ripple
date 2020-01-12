using MaterialDesignThemes.Wpf;
using Ripple.MVVM.ViewModels;
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

namespace Ripple.UserControls.Dialogs
{
    /// <summary>
    /// Interaction logic for OpenMapDialog.xaml
    /// </summary>
    public partial class OpenMapDialog : UserControl
    {
        public OpenMapViewModel ViewModel => this.DataContext as OpenMapViewModel;

        public OpenMapDialog()
        {
            InitializeComponent();
        }

        public void OnClose(object sender, DialogClosingEventArgs eventArgs)
        {
            //If user clicked Load
            if((bool)eventArgs.Parameter)
            {
                this.ViewModel.Load();
            }
        }
    }
}
