using Diploma.Models;
using Diploma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Diploma.Views
{
    /// <summary>
    /// Логика взаимодействия для EditPatientWindow.xaml
    /// </summary>
    public partial class EditPatientWindow : Window
    {
        public EditPatientWindow()
        {
            InitializeComponent();
            PatientViewModel patientViewModel = new(this);
        }
        
        private void CharactersOnly_TextInput(object sender, TextCompositionEventArgs e)
        {
            bool isCyrillic = Regex.IsMatch(e.Text, @"\p{IsCyrillic}");
            e.Handled = !isCyrillic;
        }

       
    }
}
