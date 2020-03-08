using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AcademicAgriculture.Web.Models;
using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.Products;
using AcademicAgriculture.Web.Models.Services;
using AcademicAgriculture.Web.Models.Blogs;
using AcademicAgriculture.Web.Models.References;
using AcademicAgriculture.Web.Models.Contents;
using System.Net.Mail;
using System.Net;

namespace AcademicAgriculture.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IServiceService _serviceService;
        private readonly IBlogService _blogService;
        private readonly IReferenceService _referenceService;
        private readonly IContentService _contentService;

        public HomeController(
            IAboutService aboutService,
            IProductService productService, 
            IProductCategoryService productCategoryService,
            IServiceService serviceService,
            IBlogService blogService,
            IReferenceService referenceService,
            IContentService contentService
        )
        {
            _aboutService = aboutService;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _serviceService = serviceService;
            _blogService = blogService;
            _referenceService = referenceService;
            _contentService = contentService;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View(_aboutService.GetAll().FirstOrDefault());
        }
        public IActionResult Products(int id=0)
        {
            var products = _productService.GetByCategory(id).Where(x => x.IsActive == true);
            var productCategorys = _productCategoryService.GetAll().Where(x => x.IsActive == true);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.ToList(),
                ProductCategories = productCategorys.ToList()
            };
            return View(model);
        }     
        public IActionResult ProductDetail(int id=0)
        {
            var product = _productService.GetById(id);
            var products = _productService.GetAll().Where(x => x.IsActive == true);
            ProductViewModel model = new ProductViewModel
            {
                Products = products.ToList(),
                Product = product
            };
            return View(model);
        }
        public IActionResult ServiceDetail(int id = 0)
        {
            var service = _serviceService.GetById(id);
            var services = _serviceService.GetAll().Where(x => x.IsActive == true);
            ServiceViewModel model = new ServiceViewModel
            {
                Service = service,
                Services = services.ToList()
            };
            return View(model);
        }
        public IActionResult BlogDetail(int id = 0)
        {
            var blog = _blogService.GetById(id);
            var blogs = _blogService.GetAll().Where(x => x.IsActive == true);
            BlogViewModel model = new BlogViewModel
            {
                Blog = blog,
                Blogs = blogs.ToList()
            };
            return View(model);
        }
        public IActionResult Referances()
        {
            var references = _referenceService.GetAll().Where(x => x.IsActive == true);
            ReferenceListViewModel model = new ReferenceListViewModel
            {
                References = references.ToList()
            };
            return View(model);
        }
        public IActionResult ReferanceDetail(int id = 0)
        {
            var reference = _referenceService.GetById(id);
            var references = _referenceService.GetAll().Where(x => x.IsActive == true);
            ReferenceViewModel model = new ReferenceViewModel
            {
                Reference = reference,
                References = references.ToList()
            };
            return View(model);
        }
        public IActionResult Contact()
        {
            var content= _contentService.GetAll().Where(x=>x.IsActive==true);
            ContentViewModel model = new ContentViewModel
            {
                Content = content.FirstOrDefault()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult SendFeedback(Feedback feed)
        {
            return View();
        }
     
    }

}
