using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IAddVendorUseCase
    {
        public void Execute(Vendor vendor);
    }
}