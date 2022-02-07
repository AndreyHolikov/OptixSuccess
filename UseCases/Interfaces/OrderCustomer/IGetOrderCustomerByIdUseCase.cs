using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IGetOrderCustomerByIdUseCase
    {
        OrderCustomer Execute(int orderCustomerId);
    }
}