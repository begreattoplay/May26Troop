using LayeredProducts.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayeredProducts.Presentation.Web.Models
{
    public class IndexViewModel
    {
        public IList<ProductDTO> Products { get; set; }
    }
}