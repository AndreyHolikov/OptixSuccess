using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IEditOrderCustomerUseCase
    {
        void Execute(OrderCustomer orderCustomer);
    }
}