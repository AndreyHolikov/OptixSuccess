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
    public class AddItemOrderUseCase : IAddItemOrderUseCase
    {
        private readonly IItemOrderRepository itemOrderRepository;

        public AddItemOrderUseCase(IItemOrderRepository itemOrderRepository)
        {
            this.itemOrderRepository = itemOrderRepository;
        }

        public void Execute(ItemOrder itemOrder)
        {
            itemOrderRepository.AddItemOrder(itemOrder);
        }
    }
}
