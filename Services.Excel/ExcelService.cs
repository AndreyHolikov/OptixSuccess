//using OfficeOpenXml;
using Plugins.DataStore.SQL;
using CoreBusiness;


namespace WebOptixSuccess.Services
{
    public class ExcelService
    {
        //public static byte[] GenerateExcelWorkbook(AppDbContext dbContext)
        //{
        //    var itemOrders = dbContext.ItemOrders.AsEnumerable();

        //    var stream = new MemoryStream();

        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(stream))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");

        //        // simple way
        //        workSheet.Cells.LoadFromCollection(itemOrders, true);

        //        ////// mutual
        //        ////workSheet.Row(1).Height = 20;
        //        ////workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        //        ////workSheet.Row(1).Style.Font.Bold = true;
        //        ////workSheet.Cells[1, 1].Value = "No";
        //        ////workSheet.Cells[1, 2].Value = "Name";
        //        ////workSheet.Cells[1, 3].Value = "Age";

        //        ////int recordIndex = 2;
        //        ////foreach (var item in list)
        //        ////{
        //        ////    workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
        //        ////    workSheet.Cells[recordIndex, 2].Value = item.UserName;
        //        ////    workSheet.Cells[recordIndex, 3].Value = item.Age;
        //        ////    recordIndex++;
        //        ////}

        //        return package.GetAsByteArray();
        //    }
        //}

    }
}