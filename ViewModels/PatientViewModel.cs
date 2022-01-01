using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Diploma;
using Diploma.EF;
using Diploma.Models;
using Diploma.Views;

namespace Diploma.ViewModels
{
     class PatientViewModel : INotifyPropertyChanged
     {
        private IEnumerable<Patient> dataSource;
        public IEnumerable<Patient> DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private string nameFilter ="";
        public string NameFilter
        {
            get
            {
                return nameFilter;
            }
            set
            {
                if (value != nameFilter)
                {

                    nameFilter = value;
                    OnPropertyChanged("NameFilter");
                    FilterByName();
                }
            }
        }

        public PatientViewModel()
        {
            DataSource = DataWorker.GetPatients();

        }

        private void FilterByName()
        {
            var filtered = DataWorker.GetPatients().Where(p => p.Name.StartsWith(NameFilter));
            DataSource = filtered;
            
        }
        


        #region For Interaction With Windows

        private RelayCommand openAddPatientWindow;
        public RelayCommand OpenAddPatientWindow => openAddPatientWindow ?? new RelayCommand(
                    obj =>
                    {
                        AddPatientWindow window = new AddPatientWindow();
                        Program.OpenAndCenterWindow(window);
                    }
                    );



        #endregion

        #region For ICommand Implementation
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
