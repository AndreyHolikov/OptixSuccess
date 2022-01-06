using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            // Add some  default categories

            categories = new List<Category>()
            {
                new Category() { СategoryId = 1, Name = "Beverage", Description = "Beverage"},
                new Category() { СategoryId = 2, Name = "Bakery", Description = "Bakery"},
                new Category() { СategoryId = 3, Name = "Meat", Description = "Meat"}
            };
        }

        public void AddCategory(Category category)
        {
            if(!categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))){
                var maxId = categories.Max(x => x.СategoryId);
                category.СategoryId = maxId+1;
                categories.Add(category);
            }
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.СategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }            
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.СategoryId == categoryId);
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}