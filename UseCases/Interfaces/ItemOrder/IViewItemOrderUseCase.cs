using CoreBusiness;
using CoreBusiness.Models;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewItemOrdersUseCase
    {
        IEnumerable<ItemOrder> Execute();
    }
}