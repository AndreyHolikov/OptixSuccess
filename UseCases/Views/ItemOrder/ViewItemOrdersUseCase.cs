using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases // Use Cases - Случаи применения
{
    public class ViewItemOrdersUseCase : IViewItemOrdersUseCase
    {
        private readonly IItemOrderRepository itemOrderRepository;

        public ViewItemOrdersUseCase(IItemOrderRepository itemOrderRepository) // View - Вид
        {
            this.itemOrderRepository = itemOrderRepository;
        }
        public IEnumerable<ItemOrder> Execute() // Execute - Выполнять
        {
            return itemOrderRepository.GetItemOrders();
        }
    }
}
