using CoreBusiness;
using CoreBusiness.Models;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetItemOrdersByOrderVendorIdUseCase
    {
        IEnumerable<ItemOrder> Execute(int orderVendorId);
    }
}