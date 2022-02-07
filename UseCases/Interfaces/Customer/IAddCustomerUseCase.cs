using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IAddCustomerUseCase
    {
        public void Execute(Customer customer);
    }
}