using System;
using System.Collections.Generic;
using v8proj.Models;

namespace v8proj.Services

{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Mercedes S-Class",
                    Description = "Роскошный седан премиум-класса",
                    Price = 15000000,
                    ImageUrl = "~/Content/Images/mercedes.jpg",
                    CreatedDate = DateTime.Now,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 2,
                    Name = "BMW M5",
                    Description = "Спортивный седан бизнес-класса",
                    Price = 12000000,
                    ImageUrl = "~/Content/Images/bmw.jpg",
                    CreatedDate = DateTime.Now,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 3,
                    Name = "Audi RS7",
                    Description = "Спортивный фастбек премиум-класса",
                    Price = 13000000,
                    ImageUrl = "~/Content/Images/audi.jpg",
                    CreatedDate = DateTime.Now,
                    IsAvailable = true
                }
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.Find(p => p.Id == id);
        }
    }
}