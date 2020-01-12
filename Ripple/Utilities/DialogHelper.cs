using MaterialDesignThemes.Wpf;
using Ripple.MVVM.ViewModels;
using Ripple.UserControls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripple.Utilities
{
    public static class DialogHelper
    {
        public static async Task ShowOpenMapDialog(ViewportViewModel viewport)
        {
            OpenMapDialog dialog = new OpenMapDialog()
            {
                DataContext = new OpenMapViewModel(viewport)
            };

            await DialogHost.Show(dialog, "RootDialog", null, dialog.OnClose);
        }
    }
}
