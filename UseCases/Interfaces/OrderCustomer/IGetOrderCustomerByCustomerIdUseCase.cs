using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetOrderCustomerByCustomerIdUseCase
    {
        IEnumerable<OrderCustomer> Execute(int customerId);
    }
}