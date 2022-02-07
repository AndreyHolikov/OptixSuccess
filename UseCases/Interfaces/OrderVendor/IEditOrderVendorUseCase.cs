using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IEditOrderVendorUseCase
    {
        void Execute(OrderVendor orderVendor);
    }
}