using OfficeOpenXml;


namespace Diploma.Models

{
    public class ExcelGenerator
    {      
        public byte[] Generate(Service service)
        {
            var package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets.Add("Repoert");
            return package.GetAsByteArray();
        }
    }
}