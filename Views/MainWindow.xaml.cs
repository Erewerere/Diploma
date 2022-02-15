using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Diploma.Models;
using Diploma.ViewModels;
using Diploma.Views;

namespace Diploma
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          

        }

        private void ListBox_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PatientMenuItem_Click(object sender, RoutedEventArgs e)
        {
            PatientWindow p = new();
            Program.OpenAndCenterWindow(p);

        }

        private void ServiceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ServiceWindow p = new();
            Program.OpenAndCenterWindow(p);
        }

        private void AppointServiceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ProvidedServiceWindow p = new();
            Program.OpenAndCenterWindow(p);
        }
    }
}
