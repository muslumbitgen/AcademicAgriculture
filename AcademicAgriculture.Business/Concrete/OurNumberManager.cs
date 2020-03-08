using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class OurNumberManager : IOurNumberService
    {
        private IOurNumberDal _ourNumberDal;

        public OurNumberManager(IOurNumberDal ourNumberDal)
        {
            _ourNumberDal = ourNumberDal;
        }

        public void Add(OurNumber ourNumber)
        {
            _ourNumberDal.Add(ourNumber);
        }

        public void Delete(int ourNumberId)
        {
            _ourNumberDal.Delete(new OurNumber { Id = ourNumberId });
        }

        public List<OurNumber> GetAll()
        {
            return _ourNumberDal.GetList();
        }

        public OurNumber GetById(int ourNumberId)
        {
            return _ourNumberDal.Get(p => p.Id == ourNumberId);
        }

        public void Update(OurNumber ourNumber)
        {
            _ourNumberDal.Update(ourNumber);
        }
    }
}
