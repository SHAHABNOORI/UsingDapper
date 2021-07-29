using System.Collections.Generic;
using System.Threading.Tasks;
using UsingDapper.Domain;

namespace UsingDapper.Services
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProducts();

        public Task<Product> GetProductById(int id);

        public Task<int> CreateProductAsync(Product product);

        public Task<int> UpdateProductAsync(Product product);

        public Task<int> DeleteProductAsync(Product product);
    }
}