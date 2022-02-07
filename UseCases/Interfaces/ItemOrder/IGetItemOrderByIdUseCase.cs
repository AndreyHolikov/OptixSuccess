using CoreBusiness;
using CoreBusiness.Models;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetItemOrderByIdUseCase
    {
        ItemOrder Execute(int itemOrderId);
    }
}