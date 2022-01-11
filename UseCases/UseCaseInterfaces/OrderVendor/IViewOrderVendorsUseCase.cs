using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewOrderVendorsUseCase
    {
        IEnumerable<OrderVendor> Execute();
    }
}