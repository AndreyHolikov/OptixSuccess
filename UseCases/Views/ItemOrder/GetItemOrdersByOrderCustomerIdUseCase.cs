using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetItemOrdersByOrderCustomerIdUseCase : IGetItemOrdersByOrderCustomerIdUseCase
    {
        private readonly IItemOrderRepository itemOrderRepository;

        public GetItemOrdersByOrderCustomerIdUseCase(IItemOrderRepository itemOrderRepository)
        {
            this.itemOrderRepository = itemOrderRepository;
        }
        public IEnumerable<ItemOrder> Execute(int orderCustomerId)
        {
            return itemOrderRepository.GetItemOrdersByOrderCustomerId(orderCustomerId);
        }
    }
}
