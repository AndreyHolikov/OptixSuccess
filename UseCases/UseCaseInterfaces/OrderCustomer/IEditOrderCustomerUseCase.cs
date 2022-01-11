using CoreBusiness;

namespace UseCases
{
    public interface IEditOrderCustomerUseCase
    {
        void Execute(OrderCustomer orderCustomer);
    }
}