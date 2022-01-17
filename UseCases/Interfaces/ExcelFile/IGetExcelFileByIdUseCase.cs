using CoreBusiness;

namespace UseCases
{
    public interface IGetExcelFileByIdUseCase
    {
        ExcelFile Execute(int excelFileId);
    }
}