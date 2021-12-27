using Diploma.EF;
using Diploma.Models;
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
        public PatientWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //using (DiplomaContext db = new DiplomaContext())
            //{
            //    //var players = db.Patients.ToList();
            //    //foreach (Patient p in players)
            //    //{
            //    //    MessageBox.Show(p.FIO);
            //    //}
            //    //PatientGrid.ItemsSource = p.Patients;
            //    db.Patients.Add(
            //        new Patient() { FIO ="pABEL", BirhDate = new DateTime(2015, 12, 25) });

            //    db.SaveChanges();

            //}
            using (DiplomaContext db = new DiplomaContext())
            {


                foreach (Patient u in db.Patients)
                {
                    Label1.Content = u.FIO;
                }
                PatientGrid.ItemsSource = db.Patients.Local.ToObservableCollection();

            }


        }   
    }
}
