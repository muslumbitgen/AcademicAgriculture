using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Products
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
    }
}
