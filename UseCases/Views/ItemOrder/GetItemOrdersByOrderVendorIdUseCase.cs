using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetItemOrdersByOrderVendorIdUseCase : IGetItemOrdersByOrderVendorIdUseCase
    {
        private readonly IItemOrderRepository itemOrderRepository;

        public GetItemOrdersByOrderVendorIdUseCase(IItemOrderRepository itemOrderRepository)
        {
            this.itemOrderRepository = itemOrderRepository;
        }
        public IEnumerable<ItemOrder> Execute(int orderVendorId)
        {
            return itemOrderRepository.GetItemOrdersByOrderVendorId(orderVendorId);
        }
    }
}
