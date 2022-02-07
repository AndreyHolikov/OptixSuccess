using CoreBusiness;
using CoreBusiness.Models;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewOrderCustomersUseCase
    {
        IEnumerable<OrderCustomer> Execute();
    }
}