//using OfficeOpenXml;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

//namespace Diploma.Models

//{
//    public class ExcelGenerator
//    {

//        public ExcelGenerator()
//        {
//        }
//        public byte[] Generate(Service service)
//        {
//            var package = new ExcelPackage();
//            var sheet = package.Workbook.Worksheets.Add("Repoert");
//            return package.GetAsByteArray();
//        }
//    }
//}