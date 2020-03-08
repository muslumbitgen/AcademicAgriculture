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
    public class ContentController : Controller
    {
        private IContentService _contentService;
        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }
        public IActionResult Index()
        {
            return View(_contentService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Content content)
        {
            if (ModelState.IsValid)
            {
                content.CreateDate = DateTime.Now;
                content.UpdateDate = DateTime.Now;
                _contentService.Add(content);
                TempData.Add("message", "İletişim başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            Content content = _contentService.GetById(id);
            if (content != null)
            {
                return View(content);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Content content)
        {
            if (ModelState.IsValid)
            {
                content.UpdateDate = DateTime.Now;
                _contentService.Update(content);
                TempData.Add("message", "İletişim başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _contentService.Delete(Id);
            return RedirectToAction("Index");
        }
        public JsonResult IsActiveContent(int id)
        {
            Content content = _contentService.GetById(id);
            content.IsActive = !content.IsActive;
            _contentService.Update(content);
            return Json(1);
        }
    }
}