using CoreBusiness;

namespace UseCases
{
    public interface IGetItemOrderByIdUseCase
    {
        ItemOrder Execute(int itemOrderId);
    }
}