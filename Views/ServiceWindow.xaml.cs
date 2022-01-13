using Diploma.EF;
using Diploma.Models;
using Diploma.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace Diploma.Views
{
    /// <summary>
    /// Логика взаимодействия для ServiceWindow.xaml
    /// </summary>
    public partial class ServiceWindow : Window
    {
        public ServiceWindow()
        {
            InitializeComponent();
        }
        public List<Service> Services { get; set; }   

       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ServiceViewModel serviceViewModel = new(this);
        }
        public void setLabel(string name = "")
        {
            Label1.Text = name;
        }
        public void SetDataGridSource(IEnumerable<Service> services)
        {
            Grid.ItemsSource = services.ToList();
        }

        
    }
}
