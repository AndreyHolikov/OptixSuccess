using CoreBusiness;
using CoreBusiness.Models;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetItemOrdersByOrderCustomerIdUseCase
    {
        IEnumerable<ItemOrder> Execute(int orderCustomerId);
    }
}