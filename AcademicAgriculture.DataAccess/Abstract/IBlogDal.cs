using AcademicAgriculture.Core.DataAccess;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.DataAccess.Abstract
{
    public interface IBlogDal : IEntityRepository<Blog>
    {
    }
}
