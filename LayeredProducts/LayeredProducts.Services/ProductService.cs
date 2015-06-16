using LayeredProducts.Domain;
using LayeredProducts.Domain.Models;
using LayeredProducts.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredProducts.Services
{
    public class ProductService : IProductService
    {
        private IGenericRepository _repo;

        public ProductService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<ProductDTO> GetProducts()
        {
            return _repo.Query<Product>().Select(p => new ProductDTO
            {
                CategoryName = p.Category.Name,
                Price = p.Price,
                ProductName = p.Name
            }).ToList();
        }
    }
}
