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

        //List<TextBox> AllTextBoxes(DependencyObject parent)
        //{
        //    var list = new List<TextBox>();
        //    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
        //    {
        //        var child = VisualTreeHelper.GetChild(parent, i);
        //        if (child is TextBox)
        //            list.Add(child as TextBox);
        //        list.AddRange(AllTextBoxes(child));
        //    }
        //    return list;
        //}
    }
}
