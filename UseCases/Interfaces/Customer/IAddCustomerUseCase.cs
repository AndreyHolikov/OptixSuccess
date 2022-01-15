using CoreBusiness;

namespace UseCases
{
    public interface IAddCustomerUseCase
    {
        public void Execute(Customer customer);
    }
}