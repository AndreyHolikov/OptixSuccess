using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases // Use Cases - Случаи применения
{
    public class GetExcelFileByIdUseCase : IGetExcelFileByIdUseCase
    {
        private readonly IExcelFileRepository excelFileRepository;

        public GetExcelFileByIdUseCase(IExcelFileRepository excelFileRepository)
        {
            this.excelFileRepository = excelFileRepository;
        }
        public ExcelFile Execute(int excelFileId)
        {
            return excelFileRepository.GetExcelFileById(excelFileId);
        }
    }
}
