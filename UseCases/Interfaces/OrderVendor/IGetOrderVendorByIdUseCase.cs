using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IGetOrderVendorByIdUseCase
    {
        public OrderVendor Execute(int orderVendorId);
    }
}