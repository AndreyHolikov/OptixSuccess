using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCustomersUseCase
    {
        IEnumerable<Customer> Execute();
    }
}