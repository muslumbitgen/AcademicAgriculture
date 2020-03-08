using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.Products;
using AcademicAgriculture.Web.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private IProductService _productService;
        public ProductViewComponent(IProductService productService)
        {
            _productService = productService;

        }
        public ViewViewComponentResult Invoke()
        {
            var products = _productService.GetAll().Where(x => x.IsActive == true);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.ToList()
            };
            return View(model);
        }
    }
}
