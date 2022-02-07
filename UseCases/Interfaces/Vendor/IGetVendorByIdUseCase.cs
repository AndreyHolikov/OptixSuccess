using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IGetVendorByIdUseCase
    {
        Vendor Execute(int vendorId);
    }
}