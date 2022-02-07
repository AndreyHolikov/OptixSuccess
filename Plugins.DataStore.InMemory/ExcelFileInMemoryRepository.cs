using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ExcelFileInMemoryRepository : IExcelFileRepository
    {
        private readonly List<ExcelFile> excelFiles;

        public ExcelFileInMemoryRepository()
        {
            // Add some  default products

            excelFiles = new List<ExcelFile>()
            {
                new ExcelFile() { ExcelFileId = 1, Name = "translate.txt" },
                new ExcelFile() { ExcelFileId = 2, Name = "ExcelFile2" },
                new ExcelFile() { ExcelFileId = 3, Name = "ExcelFile3" }
            };
        }

        public void AddExcelFile(ExcelFile excelFile)
        {
            if (excelFiles.Any(x => x.Name.Equals(excelFile.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (excelFiles != null && excelFiles.Count > 0)
            {
                var maxId = excelFiles.Max(x => x.ExcelFileId);
                excelFile.ExcelFileId = maxId + 1;

            }
            else
            {
                excelFile.ExcelFileId = 1;
            }
            excelFiles.Add(excelFile);
        }

        public void UpdateExcelFile(ExcelFile excelFile)
        {
            var excelFileToUpdate = GetExcelFileById(excelFile.ExcelFileId);
            if (excelFileToUpdate != null)
            {
                excelFileToUpdate.Name = excelFile.Name;
            }
        }

        public ExcelFile GetExcelFileById(int excelFileId)
        {
            return excelFiles?.Find(x => x.ExcelFileId == excelFileId);
            //return products?.SingleOrDefault(x => x.ProductId == productId);
            //return products?.FirstOrDefault(x => x.ProductId == productId);
        }

        public IEnumerable<ExcelFile> GetExcelFiles()
        {
            return excelFiles;
        }

        public void DeleteExcelFile(int excelFileId)
        {
            var excelFile = GetExcelFileById(excelFileId);
            if (excelFile != null)
            {
                excelFiles.Remove(excelFile);
            }
        }
    }
}
