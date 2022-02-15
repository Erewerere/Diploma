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
    class ProvidedServiceViewModel
    {

        // object which is selected element of datagrid in providedwindow and transmitted to
        // edit, add windows as data object to work with 
        ProvidedService providedService;

        #region ProvidedService Properties
        public int Id { get => providedService.Id; set=> providedService.Id = value ; }      
        public int PatientId { get => providedService.PatientId; set => providedService.PatientId = value; }        
        public int ServiceId { get => providedService.ServiceId; set => providedService.ServiceId = value; }
        public DateTime ProvideDate { get => providedService.ProvideDate; set => providedService.ProvideDate = value; }
        public int Count { get => providedService.Count; set => providedService.Count = value; }
        public event PropertyChangedEventHandler PropertyChanged;
        List<TextBox> changedBoxes = new();
        public static List<Patient> AllPatients { get; set; } = DataWorker.GetPatients();
        public static List<Service> AllServices { get; set; }
        #endregion



        public ProvidedServiceWindow _providedServiceWindow;
        public AddProvidedServiceWindow _addProvidedServiceWindow;
        public EditProvidedServiceWindow _editProvidedServiceWindow;



        public ProvidedServiceViewModel()
        {

        }

        public ProvidedServiceViewModel(ProvidedServiceWindow _window)
        {
            _providedServiceWindow = _window;
        }

         
        #region Model Interactions
        //private RelayCommand addProvidedService;
        //public RelayCommand AddProvidedService => addProvidedService ?? new RelayCommand(
        //            obj =>
        //            {

        //                RefreshWindow(_addprovidedServiceWindow);
        //                if (providedService.Name == null || providedService.Name.Trim().Length < 2)
        //                {
        //                    MessageBox.Show("Довжина поля Ім'я повинна буди не меншою ніж 2 букви");
        //                    SetBlock(_addprovidedServiceWindow, "Name");
        //                    return;
        //                }
        //                if (providedService.Surname == null || providedService.Surname.Trim().Length < 2)
        //                {

        //                    SetBlock(_addprovidedServiceWindow, "Surname");
        //                    return;
        //                }

        //                if (providedService.Middlename == null || providedService.Middlename.Trim().Length < 4)
        //                {
        //                    SetBlock(_addprovidedServiceWindow, "Middlename");
        //                    return;
        //                }

        //                if (DataWorker.CreateProvidedService(providedService))
        //                {
        //                    MessageBox.Show("Додано");
        //                    _addprovidedServiceWindow.DialogResult = true;
        //                    RefreshVM();

        //                    return;
        //                }
        //                MessageBox.Show("Такий користувач вже є");
        //            }
        //            );

        //public RelayCommand editProvidedService;
        //public RelayCommand EditProvidedService => editProvidedService ?? new RelayCommand(
        //    obj =>
        //    {
        //        var d = DataWorker.UpdateProvidedService(providedService);
        //        if (d == false)
        //        {
        //            MessageBox.Show("There is no update");
        //        }
        //    }
        //);

        //private RelayCommand deleteProvidedService;
        //public RelayCommand DeleteProvidedService => deleteProvidedService ?? new RelayCommand(
        //    obj =>
        //    {
        //        var d = DataWorker.DeleteProvidedService(providedService);
        //        if (d == false)
        //        {
        //            MessageBox.Show("Помилка");
        //            return;
        //        }
        //        _providedServiceWindow.SetDataGridSource(DataWorker.GetProvidedServices());
        //    }
        //);
        
        #endregion


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
            providedService = new () { Id = 0 };
        }

       

        public Control GetElement(Window window, string name)
        {
            if (window.FindName(name) is not Control element)
            {
                MessageBox.Show("Element " + name + " is not found");
                return null;
            }

            return element;

        }
        public void SetBlock(Window window, string name)
        {
            TextBox element = (TextBox)GetElement(window, name);
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
                        providedService = new() { Id=0};
                        AddPatientWindow window = new AddPatientWindow();
                        bool d = Program.OpenAndCenterWindow(window);
                        if (d == true)
                            _providedServiceWindow.SetDataGridSource(DataWorker.GetPatients());


                    }
                    );

        private RelayCommand openEditPatientWindow;
        public RelayCommand OpenEditPatientWindow => openEditPatientWindow ?? new RelayCommand(
                    obj =>
                    {

                        if (providedService == null)
                        {
                            MessageBox.Show("Оберіть пацієнта перед тим, як обновляти");
                            return;
                        }

                        EditPatientWindow window = new EditPatientWindow();

                        bool d = Program.OpenAndCenterWindow(window);
                        if (d == true)
                            _providedServiceWindow.SetDataGridSource(DataWorker.GetPatients());

                    }
                    );


        private RelayCommand closeAddPatientWindow;
        public RelayCommand CloseAddPatientWindow => closeAddPatientWindow ?? new RelayCommand(
                    obj =>
                    {
                        _addProvidedServiceWindow.Close();
                        providedService = null;
                    }
                    );


        private RelayCommand closeEditPatientWindow;
        public RelayCommand CloseEditPatientWindow => closeEditPatientWindow ?? new RelayCommand(
                    obj =>
                    {
                        _editProvidedServiceWindow.Close();
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

