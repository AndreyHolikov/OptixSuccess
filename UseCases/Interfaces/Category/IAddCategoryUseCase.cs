using CoreBusiness.Models;

namespace UseCases
{
    public interface IAddCategoryUseCase
    {
        void Execute(Category category);
    }
}