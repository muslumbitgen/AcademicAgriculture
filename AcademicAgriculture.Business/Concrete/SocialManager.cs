using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class SocialManager : ISocialService
    {
        private ISocialDal _socialDal;

        public SocialManager(ISocialDal socialDal)
        {
            _socialDal = socialDal;
        }

        public void Add(Social social)
        {
            _socialDal.Add(social);
        }

        public void Delete(int socialId)
        {
            _socialDal.Delete(new Social { Id = socialId });
        }

        public List<Social> GetAll()
        {
            return _socialDal.GetList();
        }

        public Social GetById(int socialId)
        {
            return _socialDal.Get(p => p.Id == socialId);
        }

        public void Update(Social social)
        {
            _socialDal.Update(social);
        }
    }
}
