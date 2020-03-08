using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Entities.Concrete;
using AcademicAgriculture.Web.Models.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademicAgriculture.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        private IProductCategoryService _productCategoryService;

        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            if (_productCategoryService.GetAll().Count == 0)
            {
                TempData.Add("message", "Lütfen önce kategori ekleyiniz!");
                TempData.Add("type", "warning");
                return RedirectToAction("Index", "ProductCategory");

            }
            return View(_productService.GetAll());
        }
        public IActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _productCategoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    product.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                product.CreateDate = DateTime.Now;
                product.UpdateDate = DateTime.Now;
                _productService.Add(product);
                TempData.Add("message", "Ürün başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(id),
                Categories = _productCategoryService.GetAll()
            };

            return View(model);

        }

        [HttpPost]
        public async Task<ActionResult> Update(Product product, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    product.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                product.UpdateDate = DateTime.Now;
                _productService.Update(product);
                TempData.Add("message", "Ürün başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int id)
        {
            Product product = _productService.GetById(id);
            if (product != null)
            {
                DeleteFile(product.Url);
                _productService.Delete(id);
            }
            return RedirectToAction("Index");
        }
        public void DeleteFile(string filename)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", filename);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);

            }
        }
        public JsonResult IsActiveProduct(int id)
        {
            Product product = _productService.GetById(id);
            product.IsActive = !product.IsActive;
            _productService.Update(product);
            return Json(1);
        }
    }
}