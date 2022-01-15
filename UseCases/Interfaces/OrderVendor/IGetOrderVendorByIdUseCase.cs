using CoreBusiness;

namespace UseCases
{
    public interface IGetOrderVendorByIdUseCase
    {
        OrderVendor Execute(int orderVendorId);
    }
}