using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IEditProductUseCase
    {
        void Execute(Product product);
    }
}