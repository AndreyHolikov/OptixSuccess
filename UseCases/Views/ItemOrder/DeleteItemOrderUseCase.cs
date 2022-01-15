using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteItemOrderUseCase : IDeleteItemOrderUseCase
    {
        private readonly IItemOrderRepository itemOrderRepository;

        public DeleteItemOrderUseCase(IItemOrderRepository itemOrderRepository)
        {
            this.itemOrderRepository = itemOrderRepository;
        }

        public void Delete(int itemOrderId)
        {
            itemOrderRepository.DeleteItemOrder(itemOrderId);
        }
    }
}
