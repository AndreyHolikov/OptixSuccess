using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases // Use Cases - Случаи применения
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepository) // View - Вид
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute() // Execute - Выполнять
        {
            return categoryRepository.GetCategories();
        }
    }
}
