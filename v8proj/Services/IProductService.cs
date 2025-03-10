using System.Collections.Generic;
using v8proj.Models;
namespace v8proj.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
