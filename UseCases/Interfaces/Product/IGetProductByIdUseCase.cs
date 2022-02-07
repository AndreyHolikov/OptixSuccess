using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}