using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.OurNumbers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.ViewComponents
{
    public class OurNumberViewComponent : ViewComponent
    {
        private IOurNumberService _ourNumberService;
        public OurNumberViewComponent(IOurNumberService ourNumberService)
        {
            _ourNumberService = ourNumberService;

        }
        public ViewViewComponentResult Invoke()
        {
            var ournumber = _ourNumberService.GetAll().Where(x => x.IsActive == true);
            OurNumberListViewModel model = new OurNumberListViewModel
            {
                OurNumbers = ournumber.ToList()
            };
            return View(model);
        }
    }
}
