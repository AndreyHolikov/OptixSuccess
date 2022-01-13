using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewVendorsUseCase
    {
        IEnumerable<Vendor> Execute();
    }
}