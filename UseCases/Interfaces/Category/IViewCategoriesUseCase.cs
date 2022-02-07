using CoreBusiness.Models;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}