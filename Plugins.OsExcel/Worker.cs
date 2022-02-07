using ClosedXML.Excel;
using CoreBusiness;
using CoreBusiness.Models;

namespace Plugins.OsExcel
{
    public class Worker
    {
        public XLWorkbook GetProductsXLWorkbook()
        {
            List<Product> products = new()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-0.50", Cell = "C4", Quantity = 1, Price = 1.00},
                new Product { ProductId = 2, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-0.75", Cell = "C5", Quantity = 1, Price = 1.00},
                new Product { ProductId = 3, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-1.00", Cell = "C6", Quantity = 1, Price = 1.00},
                new Product { ProductId = 4, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-1.25", Cell = "C7", Quantity = 1, Price = 1.00},
                new Product { ProductId = 5, CategoryId = 1, Name = "SofLens 59 6 pk", BC = " 8.6", Sph = "-1.50", Cell = "C8", Quantity = 1, Price = 1.00}
            };


            var workbook = new XLWorkbook();
            IXLWorksheet worksheet =
            workbook.Worksheets.Add("Products");
            worksheet.Cell(1, 1).Value = "Name";
            worksheet.Cell(1, 2).Value = "BC";
            worksheet.Cell(1, 2).Value = "Sph";

            for (int i = 1; i <= 2; i++)
            {
                worksheet.Cell(1, i).Style.Font.Bold = true;
            }

            int index = 1;
            foreach (var product in products)
            {
                worksheet.Cell(index + 1, 1).Value = product.Name;
                worksheet.Cell(index + 1, 2).Value = product.BC;
                worksheet.Cell(index + 1, 2).Value = product.Sph;

                index++;
            }

            return workbook;          
        }
    }
}