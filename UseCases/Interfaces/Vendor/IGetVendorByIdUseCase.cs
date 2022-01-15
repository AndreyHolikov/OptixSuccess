using CoreBusiness;

namespace UseCases
{
    public interface IGetVendorByIdUseCase
    {
        Vendor Execute(int vendorId);
    }
}