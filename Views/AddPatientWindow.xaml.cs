using Diploma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для PatientAdd.xaml
    /// </summary>
    public partial class AddPatientWindow : Window
    {
        public AddPatientWindow()
        {
            DataContext = new PatientViewModel(this);
            InitializeComponent();
        }

        private void CharactersOnly_TextInput(object sender, TextCompositionEventArgs e)
        {
            bool isCyrillic = Regex.IsMatch(e.Text, @"\p{IsCyrillic}");
            e.Handled = !isCyrillic;
        }
    }
   
}
