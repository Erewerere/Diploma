using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Diploma;
using Diploma.EF;
using Diploma.Models;
using Diploma.Views;

namespace Diploma.ViewModels
{
     class PatientViewModel : INotifyPropertyChanged
     {
        private static PatientWindow _patientWindow;
        private static AddPatientWindow _addpatientWindow;
        private static EditPatientWindow _editpatientWindow;
        public event PropertyChangedEventHandler PropertyChanged ;
        List<TextBox> changedBoxes = new();
        private static Patient selectedPatient;
        public Patient SelectedPatient { get => selectedPatient; set => selectedPatient = value; }
        

        #region Patient Property
        private static Patient patient = new Patient() { Id=0};
        public Patient Patient { get => patient; set  { patient = value; OnPropertyChanged(); } }
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
                patient.DisabilityGroupId = (int)value;
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

        public static  List<Decease> AllDeceases { get; set; } = DataWorker.GetDeceases();
        public static  List<SocialIntegration> AllIntergrations { get; set; } = DataWorker.GetSocialIntergration();
        public static  List<DisabilityGroup> AllDisabilityGroups { get; set; } = DataWorker.GetDisabilityGroups();

        public PatientViewModel()
        {
            
        }
        public PatientViewModel(PatientWindow window)
        {
            _patientWindow = window;

            IEnumerable<Patient> data = DataWorker.GetPatients();
           
            window.SetDataGridSource(data);
        }
        public PatientViewModel(AddPatientWindow window)
        {
            _addpatientWindow = window;
            
            
            
        }
        public PatientViewModel(EditPatientWindow window)
        {
            _editpatientWindow = window;
            AllDeceases = DataWorker.GetDeceases();
            AllIntergrations = DataWorker.GetSocialIntergration();
            AllDisabilityGroups  = DataWorker.GetDisabilityGroups();
            //Id = SelectedPatient.Id;
            //Name = SelectedPatient.Name;
            //Surname = SelectedPatient.Surname;
            //Middlename = SelectedPatient.Middlename;
            //Location = SelectedPatient.Location;
            //BirthDate = SelectedPatient.BirthDate;
            //IntegrationId = SelectedPatient.IntegrationId;
            //DeceaseId = SelectedPatient.DeceaseId;
            //Sex = SelectedPatient.Sex;         
                        
        }




        private RelayCommand addPatient;
        public RelayCommand AddPatient => addPatient ?? new RelayCommand(
                    obj =>
                    {
                        Patient = new Patient() { Name = "CHANGED" };
                        //RefreshWindow(_addpatientWindow);
                        //if (patient.Name == null || patient.Name.Trim().Length < 2 )
                        //{
                        //    MessageBox.Show("Довжина поля Ім'я повинна буди не меншою ніж 2 букви");
                        //    SetBlock(_addpatientWindow,"Name");
                        //    return;
                        //}
                        //if (patient.Surname == null || patient.Surname.Trim().Length < 2  )
                        //{

                        //    SetBlock(_addpatientWindow,"Surname");
                        //    return;
                        //}

                        //if (patient.Middlename == null || patient.Middlename.Trim().Length < 4  )
                        //{
                        //    SetBlock(_addpatientWindow,"Middlename");
                        //    return;
                        //}

                        //if (DataWorker.CreatePatient(patient))
                        //{
                        //    MessageBox.Show("Додано");
                        //    _addpatientWindow.DialogResult = true;
                        //    RefreshVM();
                            
                        //    return;
                        //}
                        //MessageBox.Show("Такий користувач вже є");
                    }
                    );

        public RelayCommand editPatient;
        public RelayCommand EditPatient => editPatient ?? new RelayCommand(
            obj=>
            {
                var d = DataWorker.UpdatePatient(patient);
                if(d == false)
                {
                    MessageBox.Show("There is no update");
                }
            }
        );



        #region Methods

        private void RefreshWindow(Window window)
        {
            foreach (var textbox in changedBoxes)
            {
                textbox.BorderBrush = Brushes.Black;
            }
        }

        private void RefreshVM()
        {
            patient = new Patient() { Id = 0 };
        }

        List<TextBox> AllTextBoxes(DependencyObject parent)
        {
            var list = new List<TextBox>();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is TextBox)
                    list.Add(child as TextBox);
                list.AddRange(AllTextBoxes(child));
            }
            return list;
        }

        public Control GetElement(Window window,string name)
        {
            if (window.FindName(name) is not Control element)
            {
                MessageBox.Show("Element " + name + " is not found");
                return null;
            }

            return element;

        }
        public void SetBlock(Window window,string name)
        {
            TextBox element = (TextBox)GetElement(window,name);
            if (element == null)
                return;
            element.BorderBrush = Brushes.Red;
            changedBoxes.Add(element);

        }

        #endregion

        #region Commands for Interaction With Windows

        private RelayCommand openAddPatientWindow;
        public RelayCommand OpenAddPatientWindow => openAddPatientWindow ?? new RelayCommand(
                    obj =>
                    {
                        AddPatientWindow window = new AddPatientWindow();
                        bool d =Program.OpenAndCenterWindow(window);
                        if(d == true)
                            _patientWindow.SetDataGridSource(DataWorker.GetPatients());
                       
                       
                    }
                    );

        private RelayCommand openEditPatientWindow;
        public RelayCommand OpenEditPatientWindow => openEditPatientWindow ?? new RelayCommand(
                    obj =>
                    {

                        if (Patient == null)
                        {
                            MessageBox.Show("Оберіть пацієнта перед тим, як обновляти");
                            return;
                        }
                        
                        EditPatientWindow window = new EditPatientWindow();
                        
                        bool d = Program.OpenAndCenterWindow(window);
                        if (d == true)
                            _patientWindow.SetDataGridSource(DataWorker.GetPatients());

                    }
                    );


        private RelayCommand closeAddPatientWindow;
        public RelayCommand CloseAddPatientWindow => closeAddPatientWindow ?? new RelayCommand(
                    obj =>
                    {
                        _addpatientWindow.Close();
                    }
                    );


        private RelayCommand closeEditPatientWindow;
        public RelayCommand CloseEditPatientWindow => closeEditPatientWindow ?? new RelayCommand(
                    obj =>
                    {
                        _editpatientWindow.Close();
                    }
                    );

        #endregion

        #region For ICommand Implementation
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        #endregion
    }
}
