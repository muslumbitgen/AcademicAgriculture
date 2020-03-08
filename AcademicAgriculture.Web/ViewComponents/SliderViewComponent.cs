using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.Sliders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private ISliderService _sliderService;
        public SliderViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;

        }
        public ViewViewComponentResult Invoke()
        {
            var sliders = _sliderService.GetAll().Where(x => x.IsActive == true);
            SliderListViewModel model = new SliderListViewModel
            {
                Sliders = sliders.ToList()
            };
            return View(model);
        }
    }
}
