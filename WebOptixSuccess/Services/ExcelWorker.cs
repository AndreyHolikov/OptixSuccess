using ClosedXML.Excel;
using CoreBusiness;
using CoreBusiness.Models;
using Plugins.DataStore.SQL;

namespace WebOptixSuccess.Services
{
    public class ExcelWorker
    {
        public XLWorkbook GetProductsXLWorkbook(AppDbContext dbContext)
        {
            var itemOrders = dbContext.ItemOrders.AsEnumerable();

            var workbook = new XLWorkbook();
            IXLWorksheet worksheet =
            workbook.Worksheets.Add("ItemOrders");
            //worksheet.Cell(1, 1).Value = "Id";
            //worksheet.Cell(1, 2).Value = "Product";
            //worksheet.Cell(1, 3).Value = "Quantity";

            //for (int i = 1; i <= 2; i++)
            //{
            //    worksheet.Cell(1, i).Style.Font.Bold = true;
            //}

            int index = 1;
            foreach (var itemOrder in itemOrders)
            {
                //worksheet.Cell(index + 1, 1).Value = itemOrder.ItemOrderId;
                //worksheet.Cell(index + 1, 2).Value = $"{itemOrder.Product.Name} BC:{itemOrder.Product.BC} Sph:{itemOrder.Product.Sph} ";
                //worksheet.Cell(index + 1, 3).Value = itemOrder.Quantity;

                worksheet.Cell(itemOrder.Product.Cell).Value = itemOrder.Quantity;

                index++;
            }

            return workbook;          
        }
    }
}