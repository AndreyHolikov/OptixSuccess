using CoreBusiness;
using CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases // Use Cases - Случаи применения
{
    public class ViewProductsUseCase : IViewProductsUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductsUseCase(IProductRepository productRepository) // View - Вид
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> Execute() // Execute - Выполнять
        {
            return productRepository.GetProducts();
        }
    }
}
