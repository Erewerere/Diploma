using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diploma
{
    /// <summary>
    /// Custom methods for Application
    /// </summary>
    public static class Program
    {
        public static bool OpenAndCenterWindow(Window window)
        {
            window.Owner = App.Current.MainWindow;
            window.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            if(window.ShowDialog() == true)
            {
                return true;
            }
            return false;
        }
    }
}
