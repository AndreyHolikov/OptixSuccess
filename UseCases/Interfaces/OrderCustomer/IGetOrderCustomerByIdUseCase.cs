using CoreBusiness;

namespace UseCases
{
    public interface IGetOrderCustomerByIdUseCase
    {
        OrderCustomer Execute(int orderCustomerId);
    }
}