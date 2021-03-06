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
    public class GetOrderVendorByIdUseCase : IGetOrderVendorByIdUseCase
    {
        private readonly IOrderVendorRepository orderVendorRepository;

        public GetOrderVendorByIdUseCase(IOrderVendorRepository orderVendorRepository)
        {
            this.orderVendorRepository = orderVendorRepository;
        }
        public OrderVendor Execute(int orderVendorId)
        {
            return orderVendorRepository.GetOrderVendorById(orderVendorId);
        }
    }
}
