using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcademicAgriculture.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductCategoryController : Controller
    {
        private IProductCategoryService _productService;
        public ProductCategoryController(IProductCategoryService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ProductCategory blogCategory)
        {
            if (ModelState.IsValid)
            {
                blogCategory.CreateDate = DateTime.Now;
                blogCategory.UpdateDate = DateTime.Now;
                _productService.Add(blogCategory);
                TempData.Add("message", "Kategori başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            ProductCategory blogCategory = _productService.GetById(id);
            if (blogCategory != null)
            {
                return View(blogCategory);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(ProductCategory blogCategory)
        {
            if (ModelState.IsValid)
            {
                blogCategory.UpdateDate = DateTime.Now;
                _productService.Update(blogCategory);
                TempData.Add("message", "Kategorisi başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _productService.Delete(Id);
            return RedirectToAction("Index");
        }
        public JsonResult IsActiveProductCategory(int id)
        {
            ProductCategory blogCategory = _productService.GetById(id);
            blogCategory.IsActive = !blogCategory.IsActive;
            _productService.Update(blogCategory);
            return Json(1);
        }
    }
}