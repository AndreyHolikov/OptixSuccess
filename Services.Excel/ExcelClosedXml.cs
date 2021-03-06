using ClosedXML.Excel;
using CoreBusiness.Models;
using Plugins.DataStore.SQL;

namespace WebOptixSuccess.Services
{
    public class ExcelClosedXml
    {
        AppDbContext dbContext;
        public ExcelClosedXml(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void ParsingExcelFile(string path, int OrederCustomerId)
        {
            //string newPath = path.Replace(@"\\", @"\");
            //string path = Path.Combine(Environment.ContentRootPath,
            //    Environment.EnvironmentName, "unsafe_uploads",
            //    fileName);
            var workbook = new XLWorkbook(path);

            var worksheet1 = workbook.Worksheets.First();
            var worksheet = workbook.Worksheets.Add("WorkSheet");


            IEnumerable<Product> products = dbContext.Products.ToList();
            int productCount = products.Count();
            List<ItemOrder> itemOrders = new List<ItemOrder>();

            foreach (var product in products)
            {
                IXLCell? cell = worksheet1.Cell(product.Cell);
                if (cell != null)
                {
                    #pragma warning disable 8600, 8602

                    string quantityCell = cell?.Value?.ToString();
                    int quantity = 0;
                    if (!string.IsNullOrEmpty(quantityCell))
                    {
                        quantity = cell.GetValue<int>();
                    }
                    //    int quantity = int.Parse(quantityCell);

                    if (quantity > 0)
                    {
                        worksheet.Cell(product.Cell).Value = quantity;
                        itemOrders.Add(new ItemOrder() { OrderCustomerId = OrederCustomerId, Edited = DateTime.Now, Product = product, Quantity = quantity });
                        dbContext.ItemOrders.AddRange(itemOrders);
                    }

                    #pragma warning restore 8600, 8602
                }
            }
            if (itemOrders.Count > 0)
            {
                dbContext.ItemOrders.AddRange(itemOrders);
                var OrederCustomer = dbContext.OrderCustomers.Find(OrederCustomerId);
                if (OrederCustomer != null) {
                    OrederCustomer.Edited = DateTime.Now;
                    dbContext.OrderCustomers.Update(OrederCustomer);
                }                
                dbContext.SaveChanges();
            }
            workbook.SaveAs(path);

            //var workbook = new XLWorkbook(path);

            //var worksheet = workbook.Worksheets.Add("Sample Sheet");
            //worksheet.Cell("A1").Value = "Hello World!";
            //workbook.SaveAs(path);

            //var excelApp = new Excel.Application();
            //excelApp.Workbooks.Open(path);
            //Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

            //IEnumerable<Product> products = dbContext.Products.ToList();
            //int productCount = products.Count();
            //foreach (var product in products)
            //{
            //    var quantityCell = workSheet.get_Range(product.Cell, Type.Missing);
            //    int quantity = Convert.ToInt32(quantityCell.Value2);
            //    List<ItemOrder> itemOrders = new List<ItemOrder>();
            //    if (quantity > 0)
            //    {
            //        itemOrders.Add(new ItemOrder() { OrderCustomerId = OrederCustomerId, Edited = DateTime.Now, Product = product, Quantity = quantity });
            //    }

            //    dbContext.ItemOrders.AddRange(itemOrders);
            //}
            //dbContext.SaveChanges();

            //using (var workbook = new XLWorkbook())
            //{
            //    var worksheet = workbook.Worksheets.Add("Sample Sheet");
            //    worksheet.Cell("A1").Value = "Hello World!";
            //    worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";
            //    workbook.SaveAs("HelloWorld.xlsx");
            //}


            //wb.SaveAs(output);
        }
    }
}
