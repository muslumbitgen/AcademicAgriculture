using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Entities;
using AcademicAgriculture.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcademicAgriculture.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IBlogService _blogService;
        private IProductService _productService;
        private CustomIdentityDbContext _customIdentityDbContext;

        public AdminController(IBlogService blogService, IProductService productService, CustomIdentityDbContext customIdentityDbContext)
        {
            _blogService = blogService;
            _productService = productService;
            _customIdentityDbContext = customIdentityDbContext;
        }
        public IActionResult Index()
        {
            AdminCount model = new AdminCount
            {
                BlogCount = _blogService.GetAll().Count,
                ProductCount=_productService.GetAll().Count,
                UserCount=_customIdentityDbContext.Users.ToList().Count
            };
            return View(model);
        }
    }
}