using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IAddProductUseCase
    {
        public void Execute(Product product);
    }
}