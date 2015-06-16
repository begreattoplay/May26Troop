using AutoMapper;
using LayeredProducts.Domain.Models;
using LayeredProducts.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredProducts.Services
{
    public class AutoMapperStartup
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<Product, ProductDTO>();
        }
    }
}
