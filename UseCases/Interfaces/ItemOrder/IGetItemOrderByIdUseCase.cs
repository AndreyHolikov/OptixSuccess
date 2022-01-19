using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetItemOrderByIdUseCase
    {
        ItemOrder Execute(int itemOrderId);
    }
}