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
    public class ViewOrderVendorsUseCase : IViewOrderVendorsUseCase
    {
        private readonly IOrderVendorRepository orderVendorsRepository;

        public ViewOrderVendorsUseCase(IOrderVendorRepository orderVendorsRepository) // View - Вид
        {
            this.orderVendorsRepository = orderVendorsRepository;
        }
        public IEnumerable<OrderVendor> Execute() // Execute - Выполнять
        {
            return orderVendorsRepository.GetOrderVendors();
        }
    }
}
