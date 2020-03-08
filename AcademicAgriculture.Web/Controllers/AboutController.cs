using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademicAgriculture.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        private IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            return View(_aboutService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(About about, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    about.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                about.CreateDate = DateTime.Now;
                about.UpdateDate = DateTime.Now;
                _aboutService.Add(about);
                TempData.Add("message", "Hakkımızda başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            About about = _aboutService.GetById(id);
            if (about != null)
            {
                return View(about);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(About about, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    about.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                about.UpdateDate = DateTime.Now;
                _aboutService.Update(about);
                TempData.Add("message", "Hakkkımızda başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _aboutService.Delete(Id);
            About about = _aboutService.GetById(Id);
            if (about != null)
            {
                DeleteFile(about.Url);
                _aboutService.Delete(Id);
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
        public JsonResult IsActiveAbout(int id)
        {
            About about = _aboutService.GetById(id);
            about.IsActive = !about.IsActive;
            _aboutService.Update(about);
            return Json(1);
        }
    }
}