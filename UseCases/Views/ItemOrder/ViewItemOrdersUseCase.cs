using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases // Use Cases - Случаи применения
{
    public class ViewExcelFilesUseCase : IViewItemOrdersUseCase
    {
        private readonly IItemOrderRepository itemOrderRepository;

        public ViewExcelFilesUseCase(IItemOrderRepository itemOrderRepository) // View - Вид
        {
            this.itemOrderRepository = itemOrderRepository;
        }
        public IEnumerable<ItemOrder> Execute() // Execute - Выполнять
        {
            return itemOrderRepository.GetItemOrders();
        }
    }
}
