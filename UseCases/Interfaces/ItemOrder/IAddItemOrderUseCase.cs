using CoreBusiness;

namespace UseCases
{
    public interface IAddItemOrderUseCase
    {
        public void Execute(ItemOrder itemOrder);
    }
}