using Diploma.EF;
using Diploma.Models;
//using Diploma.Views;
//using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Diploma.Views;

namespace Diploma.ViewModels
{
    public class ServiceViewModel : INotifyPropertyChanged
    {
        private static ServiceWindow _window;
        public Service Service = new Service() { Id=0};
        private List<Service> services;
        public List<Service> Services
        {
            get
            {
                return services;
            }
            set {
                services = value;
                OnPropertyChanged();
            }
        }
        private Service service = new Service() { Name = "" };       
        public string Name { get => service.Name ?? ""; set { service.Name = value; OnPropertyChanged(); } }

        public ServiceViewModel(ServiceWindow window)
        { _window = window;

            DiplomaContext db = new();
            db.ReabilitationTypes.Load();
            Services = db.Services.ToList();
            _window.SetDataGridSource(Services);
        }
        public ServiceViewModel()
        {
          
        }
        private RelayCommand editService;
        public RelayCommand AddPatient => editService ?? new RelayCommand(
                    obj =>
                    {
                        _window.setLabel(service.Name);
                    }
                    );




        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private RelayCommand click;
        //private Workbook xlWorkBook;
        public RelayCommand Click => click ??= new RelayCommand(obj => {

            //var service = new Service { Name = "a" };
            ////var report = new ExcelGenerator().Generate(service);
            //File.WriteAllBytes("Report.xlsx", report);
            //Microsoft.Office.Interop.Excel.Application xlApp = new
            //Microsoft.Office.Interop.Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Add();
            //Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //xlWorkSheet.Cells[1, 1] = "ID";
            //xlWorkSheet.Cells[1, 2] = "Name";
            //xlWorkSheet.Cells[2, 1] = "1";
            //xlWorkSheet.Cells[2, 2] = "One";
            //xlWorkSheet.Cells[3, 1] = "2";
            //xlWorkSheet.Cells[3, 2] = "Two";
            //xlWorkBook.SaveAs("your-file-name.xls");
            
        });

        
    }
}
