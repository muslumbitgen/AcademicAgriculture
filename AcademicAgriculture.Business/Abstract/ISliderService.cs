using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface ISliderService
    {
        List<Slider> GetAll();
        void Add(Slider slider);
        void Update(Slider slider);
        void Delete(int sliderId);
        Slider GetById(int sliderId);
    }
}
