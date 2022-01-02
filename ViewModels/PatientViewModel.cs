using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Diploma;
using Diploma.EF;
using Diploma.Models;
using Diploma.Views;

namespace Diploma.ViewModels
{
     class PatientViewModel : INotifyPropertyChanged
     {
        private Window _patientWindow;
        public event PropertyChangedEventHandler PropertyChanged ;
       

        #region Patient Property
        public Patient patient = new() { Name = "a", Surname = "b", Middlename = "c", Sex = Sex.Чоловіча };
        public int Id
        {
            get { return patient.Id; }
            set
            {
                patient.Id = value;
                OnPropertyChanged("Id");
            }
        }
        public DisabilityGroup DisabilityGroup
        {
            get { return patient.DisabilityGroup; }
            set
            {
                patient.DisabilityGroup = value;
                OnPropertyChanged("DisabilityGroup");
            }
        }
        public int DisabilityGroupId
        {
            get { return patient.DisabilityGroupId; }
            set
            {
                patient.DisabilityGroupId = value;
                OnPropertyChanged("DisabilityGroupId");
            }
        }
        public string Name
        {
            get { return patient.Name; }
            set
            {
                patient.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get { return patient.Surname; }
            set
            {
                patient.Surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public string Middlename
        {
            get { return patient.Middlename; }
            set
            {
                patient.Middlename = value;
                OnPropertyChanged("Middlename");
            }
        }
        public int Age
        {
            get { return patient.Age; }
            set
            {
                patient.Age = value;
                OnPropertyChanged("Age");
            }
        }
        public DateTime BirthDate
        {
            get { return patient.BirthDate; }
            set
            {
                patient.BirthDate = value;
                OnPropertyChanged("BirthDate");
            }
        }
        public string Location
        {
            get { return patient.Location; }
            set
            {
                patient.Location = value;
                OnPropertyChanged("Location");
            }
        }
        public Sex Sex
        {
            get { return patient.Sex; }
            set
            {
                patient.Sex = value;
                OnPropertyChanged("Sex");
            }
        }
        public SocialIntegration Integration
        {
            get { return patient.Integration; }
            set
            {
                patient.Integration = value;
                OnPropertyChanged("Integrationp");
            }
        }
        public int IntegrationId
        {
            get { return patient.IntegrationId; }
            set
            {
                patient.IntegrationId = value;
                OnPropertyChanged("IntegrationId");
            }
        }
        public Decease Decease
        {
            get { return patient.Decease; }
            set
            {
                patient.Decease = value;
                OnPropertyChanged("Decease");
            }
        }
        public int DeceaseId
        {
            get { return patient.DeceaseId; }
            set
            {
                patient.DeceaseId = value;
                OnPropertyChanged("DeceaseId");
            }
        }

        #endregion


        public PatientViewModel()
        {            
        }
        public PatientViewModel(PatientWindow window)
        {
            _patientWindow = window;
            IEnumerable<Patient> data = DataWorker.GetPatients();
            window.SetDataGridSource(data);
        }

        


        private RelayCommand addPatient;
        public RelayCommand AddPatient => addPatient ?? new RelayCommand(
                    obj =>
                    {
                        if (DataWorker.CreatePatient(patient))
                        {
                            MessageBox.Show("Додано");
                            return;
                        }
                        MessageBox.Show("Такий користувач вже є");
                    }
                    );


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
