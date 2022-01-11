using CoreBusiness;

namespace UseCases
{
    public interface IGetCustomerByIdUseCase
    {
        Customer Excecute(int customerId);
    }
}