using CoreBusiness;

namespace UseCases
{
    public interface IGetVendorByIdUseCase
    {
        Vendor Excecute(int vendorId);
    }
}