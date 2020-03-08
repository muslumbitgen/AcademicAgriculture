using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.Abouts;
using AcademicAgriculture.Web.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private IAboutService _aboutService;
        public AboutViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;

        }
        public ViewViewComponentResult Invoke()
        {
            var about = _aboutService.GetAll().Where(x => x.IsActive == true);
            AboutViewModel model = new AboutViewModel
            {
                About = about.FirstOrDefault()
            };
            return View(model);
        }
    }
}
