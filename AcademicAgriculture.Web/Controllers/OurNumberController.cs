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
    public class OurNumberController : Controller
    {
        private IOurNumberService _ourNumberService;
        public OurNumberController(IOurNumberService ourNumberService)
        {
            _ourNumberService = ourNumberService;
        }
        public IActionResult Index()
        {
            return View(_ourNumberService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(OurNumber ourNumber)
        {
            if (ModelState.IsValid)
            {
                ourNumber.CreateDate = DateTime.Now;
                ourNumber.UpdateDate = DateTime.Now;
                _ourNumberService.Add(ourNumber);
                TempData.Add("message", "Sayılarımız başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            OurNumber ourNumber = _ourNumberService.GetById(id);
            if (ourNumber != null)
            {
                return View(ourNumber);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(OurNumber ourNumber)
        {
            if (ModelState.IsValid)
            {
                ourNumber.UpdateDate = DateTime.Now;
                _ourNumberService.Update(ourNumber);
                TempData.Add("message", "Sayılarımız başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _ourNumberService.Delete(Id);
            return RedirectToAction("Index");
        }
        public JsonResult IsActiveOurNumber(int id)
        {
            OurNumber ourNumber = _ourNumberService.GetById(id);
            ourNumber.IsActive = !ourNumber.IsActive;
            _ourNumberService.Update(ourNumber);
            return Json(1);
        }
    }
}