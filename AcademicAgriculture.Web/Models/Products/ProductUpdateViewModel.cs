using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Products
{
    public class ProductUpdateViewModel
    {
        public List<ProductCategory> Categories { get; internal set; }
        public Product Product { get; set; }
    }
}
