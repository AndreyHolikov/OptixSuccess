using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class EditItemOrderUseCase : IEditItemOrderUseCase
    {
        private readonly IItemOrderRepository iItemOrderRepository;

        public EditItemOrderUseCase(IItemOrderRepository iItemOrderRepository)
        {
            this.iItemOrderRepository = iItemOrderRepository;
        }

        public void Execute(ItemOrder iItemOrder)
        {
            iItemOrderRepository.UpdateItemOrder(iItemOrder);
        }
    }
}
