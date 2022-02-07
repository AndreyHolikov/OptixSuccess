using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IAddOrderVendorUseCase
    {
        public void Execute(OrderVendor orderVendor);
    }
}