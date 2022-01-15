using CoreBusiness;

namespace UseCases
{
    public interface IAddOrderVendorUseCase
    {
        public void Execute(OrderVendor orderVendor);
    }
}