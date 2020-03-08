using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class SliderManager:ISliderService
    {
        private ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider slider)
        {
            _sliderDal.Add(slider);
        }

        public void Delete(int sliderId)
        {
            _sliderDal.Delete(new Slider { Id = sliderId });
        }

        public List<Slider> GetAll()
        {
            return _sliderDal.GetList();
        }

        public Slider GetById(int sliderId)
        {
            return _sliderDal.Get(p => p.Id == sliderId);
        }

        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
