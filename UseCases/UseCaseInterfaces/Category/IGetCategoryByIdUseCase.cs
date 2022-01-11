using CoreBusiness;

namespace UseCases
{
    public interface IGetCategoryByIdUseCase
    {
        Category Excecute(int categoryId);
    }
}