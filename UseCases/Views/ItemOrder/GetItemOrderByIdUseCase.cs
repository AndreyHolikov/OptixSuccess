using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetItemOrderByIdUseCase : IGetItemOrderByIdUseCase
    {
        private readonly IItemOrderRepository itemOrderRepository;

        public GetItemOrderByIdUseCase(IItemOrderRepository itemOrderRepository)
        {
            this.itemOrderRepository = itemOrderRepository;
        }
        public ItemOrder Execute(int itemOrderId)
        {
            return itemOrderRepository.GetItemOrderById(itemOrderId);
        }
    }
}
