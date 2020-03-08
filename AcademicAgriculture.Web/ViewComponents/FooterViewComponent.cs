using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.Abouts;
using AcademicAgriculture.Web.Models.Footers;
using AcademicAgriculture.Web.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private IContentService _contentService;
        private IAboutService _aboutService;
        private IServiceService _serviceService;
        private ISocialService _socialService;
        public FooterViewComponent(IContentService contentService, ISocialService socialService, IAboutService aboutService, IServiceService serviceService)
        {
            _contentService = contentService;
            _socialService = socialService;
            _serviceService = serviceService;
            _aboutService = aboutService;

        }
        public ViewViewComponentResult Invoke()
        {
            var content = _contentService.GetAll().Where(x => x.IsActive == true);
            var social = _socialService.GetAll().Where(x => x.IsActive == true);
            var about = _aboutService.GetAll().Where(x => x.IsActive == true);
            var services = _serviceService.GetAll().Where(x => x.IsActive == true);
            FooterViewModel model = new FooterViewModel
            {
                Content = content.FirstOrDefault(),
                Socials = social.ToList(),
                About = about.FirstOrDefault(),
                Services = services.ToList()
            };
            return View(model);
        }
    }
}
