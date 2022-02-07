using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IEditVendorUseCase
    {
        void Execute(Vendor vendor);
    }
}