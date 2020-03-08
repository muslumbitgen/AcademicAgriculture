using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
            _aboutDal.Add(about);
        }

        public void Delete(int aboutId)
        {
            _aboutDal.Delete(new About { Id = aboutId });
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetList();
        }

        public About GetById(int aboutId)
        {
            return _aboutDal.Get(p => p.Id == aboutId);
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
