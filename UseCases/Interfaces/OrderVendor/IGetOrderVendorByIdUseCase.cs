using CoreBusiness;

namespace UseCases
{
    public interface IGetOrderVendorByIdUseCase
    {
        public OrderVendor Execute(int orderVendorId);
    }
}