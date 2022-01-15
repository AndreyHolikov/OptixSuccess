using CoreBusiness;

namespace UseCases
{
    public interface IAddOrderCustomerUseCase
    {
        public void Execute(OrderCustomer orderCustomer);
    }
}