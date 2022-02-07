using CoreBusiness.Models;

namespace UseCases
{
    public interface IGetCategoryByIdUseCase
    {
        public Category Execute(int categoryId);
    }
}