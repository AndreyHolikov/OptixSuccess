using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IAddOrderCustomerUseCase
    {
        public void Execute(OrderCustomer orderCustomer);
    }
}