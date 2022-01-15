using CoreBusiness;

namespace UseCases
{
    public interface IGetCustomerByIdUseCase
    {
        Customer Execute(int customerId);
    }
}