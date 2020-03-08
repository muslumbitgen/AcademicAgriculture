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
    public class SliderController : Controller
    {
        private ISliderService _sliderService;
        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IActionResult Index()
        {
            return View(_sliderService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Slider slider, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    slider.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                slider.CreateDate = DateTime.Now;
                slider.UpdateDate = DateTime.Now;
                _sliderService.Add(slider);
                TempData.Add("message", "Slider başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            Slider slider = _sliderService.GetById(id);
            if (slider != null)
            {
                return View(slider);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Slider slider, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    slider.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                slider.UpdateDate = DateTime.Now;
                _sliderService.Update(slider);
                TempData.Add("message", "Slider başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _sliderService.Delete(Id);
            Slider slider = _sliderService.GetById(Id);
            if (slider != null)
            {
                DeleteFile(slider.Url);
                _sliderService.Delete(Id);
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
        public JsonResult IsActiveSlider(int id)
        {
            Slider slider = _sliderService.GetById(id);
            slider.IsActive = !slider.IsActive;
            _sliderService.Update(slider);
            return Json(1);
        }
    }
}