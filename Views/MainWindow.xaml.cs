using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
using Diploma.EF;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DiplomaContext db = new();
            Configuration config =
       ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            TextBox1.Text = config.FilePath;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ConfigurationManager.AppSettings.Set("connection_database", "kursach") ;
            UpdateAppConfig("connection_database", "Diploma");
        }
        private static void UpdateAppConfig(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }
            Configuration config =
        ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }

            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

        }
    }
}
