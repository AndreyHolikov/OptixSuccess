using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IGetCustomerByIdUseCase
    {
        Customer Execute(int customerId);
    }
}