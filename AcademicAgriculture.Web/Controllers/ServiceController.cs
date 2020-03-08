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
    public class ServiceController : Controller
    {
        private IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IActionResult Index()
        {
            return View(_serviceService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Service service, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    service.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                service.CreateDate = DateTime.Now;
                service.UpdateDate = DateTime.Now;
                _serviceService.Add(service);
                TempData.Add("message", "Hizmet başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            Service service = _serviceService.GetById(id);
            if (service != null)
            {
                return View(service);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Service service, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    service.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                service.UpdateDate = DateTime.Now;
                _serviceService.Update(service);
                TempData.Add("message", "Hizmet başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _serviceService.Delete(Id);
            Service service = _serviceService.GetById(Id);
            if (service != null)
            {
                DeleteFile(service.Url);
                _serviceService.Delete(Id);
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
        public JsonResult IsActiveService(int id)
        {
            Service service = _serviceService.GetById(id);
            service.IsActive = !service.IsActive;
            _serviceService.Update(service);
            return Json(1);
        }
    }
}