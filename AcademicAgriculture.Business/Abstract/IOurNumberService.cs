using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface IOurNumberService
    {
        List<OurNumber> GetAll();
        void Add(OurNumber ourNumber);
        void Update(OurNumber ourNumber);
        void Delete(int ourNumberId);
        OurNumber GetById(int ourNumberId);
    }
}
