using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IEditItemOrderUseCase
    {
        public void Execute(ItemOrder itemOrder);
    }
}