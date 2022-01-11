using CoreBusiness;

namespace UseCases
{
    public interface IGetOrderCustomerByIdUseCase
    {
        Customer Excecute(int orderCustomerId);
    }
}