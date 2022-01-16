﻿using CoreBusiness;
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
        private readonly IItemOrderRepository itemOrderRepository;

        public EditItemOrderUseCase(IItemOrderRepository itemOrderRepository)
        {
            this.itemOrderRepository = itemOrderRepository;
        }

        public void Execute(ItemOrder iItemOrder)
        {
            itemOrderRepository.UpdateItemOrder(iItemOrder);
        }
    }
}
