using MyDemoAzureFn.Services.Dto;
using System;
using System.Collections.Generic;

namespace MyDemoAzureFn.Services
{
    public class CategoryService
    {
        public List<Category> GetCategories()
        {
            var categories = new List<Category>{
               new Category() { Id= 1, Name = "Food", Description="Food", CreatedDate = DateTime.Now },
               new Category() { Id= 1, Name = "Electronics", Description="Electronics Items", CreatedDate = DateTime.Now },
               new Category() { Id= 1, Name = "Cloths", Description="Cloths", CreatedDate = DateTime.Now },
               new Category() { Id= 1, Name = "Decor", Description="House Decoration", CreatedDate = DateTime.Now }
            };
            return categories;
        }
    }
}
