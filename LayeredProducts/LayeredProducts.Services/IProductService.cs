using LayeredProducts.Domain.Models;
using LayeredProducts.Services.Models;
using System;
using System.Collections.Generic;
namespace LayeredProducts.Services
{
    public interface IProductService
    {
        IList<ProductDTO> GetProducts();
    }
}
