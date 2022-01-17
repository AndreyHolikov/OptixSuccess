using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IExcelFileRepository
    {
        public IEnumerable<ExcelFile> GetExcelFiles();
        public void AddExcelFile(ExcelFile excelFile);
        public void UpdateExcelFile(ExcelFile excelFile);
        public ExcelFile GetExcelFileById(int excelFileId);
        public void DeleteExcelFile(int excelFileId);
    }
}
