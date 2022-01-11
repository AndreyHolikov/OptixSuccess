using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            // Add some  default products

            products = new List<Product>()
            {
                new Product() { ProductId = 1, Name = "Product-501", Description = "Customer-501.1"},
                new Product() { ProductId = 2, Name = "Product-502", Description = "Customer-502.1"},
                new Product() { ProductId = 3, Name = "Product-503", Description = "Customer-503.1"}
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;

            }
            else
            {
                product.ProductId = 1;
            }
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
            }
        }

        public Product GetProductById(int productId)
        {
            return products?.Find(x => x.ProductId == productId);
            //return products?.SingleOrDefault(x => x.ProductId == productId);
            //return products?.FirstOrDefault(x => x.ProductId == productId);
        }

        public IEnumerable<Product> GetCategories()
        {
            return products;
        }

        public void DeleteProduct(int productId)
        {
            var cat = GetProductById(productId);
            if (cat != null)
            {
                products.Remove(cat);
            }
        }
    }
}
