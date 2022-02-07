using CoreBusiness;
using CoreBusiness.Models;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewOrderVendorsUseCase
    {
        IEnumerable<OrderVendor> Execute();
    }
}