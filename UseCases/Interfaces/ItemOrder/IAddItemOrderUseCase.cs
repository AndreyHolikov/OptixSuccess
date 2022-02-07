using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IAddItemOrderUseCase
    {
        public void Execute(ItemOrder itemOrder);
    }
}