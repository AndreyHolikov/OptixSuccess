using CoreBusiness;

namespace UseCases
{
    public interface IGetOrderCustomerByIdUseCase
    {
        OrderCustomer Excecute(int orderCustomerId);
    }
}