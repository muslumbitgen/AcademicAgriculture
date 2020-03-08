using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface ISocialService
    {
        List<Social> GetAll();
        void Add(Social social);
        void Update(Social social);
        void Delete(int socialId);
        Social GetById(int socialId);
    }
}
