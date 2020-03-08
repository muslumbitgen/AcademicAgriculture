using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        private IServiceService _serviceService;
        public ServiceViewComponent(IServiceService serviceService)
        {
            _serviceService = serviceService;

        }
        public ViewViewComponentResult Invoke()
        {
            var services = _serviceService.GetAll().Where(x => x.IsActive == true);
            ServiceListViewModel model = new ServiceListViewModel
            {
                Services = services.ToList()
            };
            return View(model);
        }
    }
}
