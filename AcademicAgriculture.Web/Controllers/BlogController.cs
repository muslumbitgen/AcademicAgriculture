using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Entities.Concrete;
using AcademicAgriculture.Web.Models.Blogs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademicAgriculture.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            return View(_blogService.GetAll());
        }
        public IActionResult Add()
        {
            var model = new BlogAddViewModel
            {
                Blog = new Blog(),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Blog blog, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    blog.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                blog.CreateDate = DateTime.Now;
                blog.UpdateDate = DateTime.Now;
                _blogService.Add(blog);
                TempData.Add("message", "Haber başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new BlogUpdateViewModel
            {
                Blog = _blogService.GetById(id)
            };

            return View(model);

        }

        [HttpPost]
        public async Task<ActionResult> Update(Blog blog, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    blog.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                blog.UpdateDate = DateTime.Now;
                _blogService.Update(blog);
                TempData.Add("message", "Haber başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int id)
        {
            Blog blog = _blogService.GetById(id);
            if (blog != null)
            {
                DeleteFile(blog.Url);
                _blogService.Delete(id);
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
        public JsonResult IsActiveBlog(int id)
        {
            Blog blog = _blogService.GetById(id);
            blog.IsActive = !blog.IsActive;
            _blogService.Update(blog);
            return Json(1);
        }
    }
}