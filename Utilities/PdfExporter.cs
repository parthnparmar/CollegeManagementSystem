using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;

namespace CollegeManagementSystem.Utilities
{
    public static class PdfExporter
    {
        public static byte[] ExportToPdf(List<string[]> data)
        {
            using (var ms = new MemoryStream())
            {
                var doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, ms);
                doc.Open();

                var table = new PdfPTable(data[0].Length);
                foreach (var row in data)
                {
                    foreach (var cell in row)
                        table.AddCell(new Phrase(cell));
                }

                doc.Add(table);
                doc.Close();
                return ms.ToArray();
            }
        }
    }
}
