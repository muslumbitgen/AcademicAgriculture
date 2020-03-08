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
    public class SocialController : Controller
    {
        private ISocialService _socialService;
        public SocialController(ISocialService socialService)
        {
            _socialService = socialService;
        }
        public IActionResult Index()
        {
            return View(_socialService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Social social)
        {
            if (ModelState.IsValid)
            {
                social.CreateDate = DateTime.Now;
                social.UpdateDate = DateTime.Now;
                _socialService.Add(social);
                TempData.Add("message", "Sosyal başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            Social social = _socialService.GetById(id);
            if (social != null)
            {
                return View(social);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Social social)
        {
            if (ModelState.IsValid)
            {
                social.UpdateDate = DateTime.Now;
                _socialService.Update(social);
                TempData.Add("message", "Sosyal başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _socialService.Delete(Id);
            return RedirectToAction("Index");
        }
        public JsonResult IsActiveSocial(int id)
        {
            Social social = _socialService.GetById(id);
            social.IsActive = !social.IsActive;
            _socialService.Update(social);
            return Json(1);
        }
    }
}