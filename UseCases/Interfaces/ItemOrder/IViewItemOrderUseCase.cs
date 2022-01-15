using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewItemOrdersUseCase
    {
        IEnumerable<ItemOrder> Execute();
    }
}