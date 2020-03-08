using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetAll();
        void Add(About about);
        void Update(About about);
        void Delete(int aboutId);
        About GetById(int aboutId);
    }
}
