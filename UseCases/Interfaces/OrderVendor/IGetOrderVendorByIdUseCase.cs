using CoreBusiness;

namespace UseCases
{
    public interface IGetOrderVendorByIdUseCase
    {
        OrderVendor Excecute(int orderVendorId);
    }
}