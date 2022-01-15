﻿using Diploma.EF;
using Diploma.Models;
using Diploma.ViewModels;
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
using System.Windows.Shapes;

namespace Diploma.Views
{
    /// <summary>
    /// Логика взаимодействия для PatientWindow.xaml
    /// </summary>
    public partial class PatientWindow : Window
    {
        private PatientViewModel patientView;
        public PatientWindow()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PatientViewModel patientView = new(this);            
        }


        public void SetDataGridSource(IEnumerable<Patient> patients)
        {
            PatientGrid.ItemsSource = patients;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchName.Text.Length < 1)
            {
                var patientData = DataWorker.GetPatients();              
                SetDataGridSource(patientData);
            }

            var filtered = DataWorker.GetPatients().Where(p => p.Name.StartsWith(SearchName.Text));
            SetDataGridSource(filtered);
        }


       
    }
}
