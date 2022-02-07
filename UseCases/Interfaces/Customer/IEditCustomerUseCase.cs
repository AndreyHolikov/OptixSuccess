using CoreBusiness;
using CoreBusiness.Models;

namespace UseCases
{
    public interface IEditCustomerUseCase
    {
        void Execute(Customer customer);
    }
}