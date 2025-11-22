using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace CollegeManagementSystem.Utilities
{
    public static class ExcelExporter
    {
        public static byte[] ExportToExcel<T>(List<T> data, string sheetName = "Data")
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add(sheetName);
                ws.Cells["A1"].LoadFromCollection(data, true);
                return package.GetAsByteArray();
            }
        }
    }
}
