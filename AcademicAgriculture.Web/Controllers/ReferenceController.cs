using System;
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
    public class ReferenceController : Controller
    {
        private IReferenceService _referenceService;
        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }
        public IActionResult Index()
        {
            return View(_referenceService.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Reference reference, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    reference.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                reference.CreateDate = DateTime.Now;
                reference.UpdateDate = DateTime.Now;
                _referenceService.Add(reference);
                TempData.Add("message", "Hakkımızda başarıyla eklendi");
                TempData.Add("type", "success");
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            Reference reference = _referenceService.GetById(id);
            if (reference != null)
            {
                return View(reference);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Reference reference, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    reference.Url = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                reference.UpdateDate = DateTime.Now;
                _referenceService.Update(reference);
                TempData.Add("message", "Hakkkımızda başarıyla güncellendi");
                TempData.Add("type", "success");
                return RedirectToAction("Index");

            }

            return RedirectToAction("Update");
        }
        public ActionResult Delete(int Id)
        {
            _referenceService.Delete(Id);
            Reference reference = _referenceService.GetById(Id);
            if (reference != null)
            {
                DeleteFile(reference.Url);
                _referenceService.Delete(Id);
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
        public JsonResult IsActiveReference(int id)
        {
            Reference reference = _referenceService.GetById(id);
            reference.IsActive = !reference.IsActive;
            _referenceService.Update(reference);
            return Json(1);
        }
    }
}