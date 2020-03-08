﻿using AcademicAgriculture.Core.DataAccess.EntityFramework;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.DataAccess.Concrete.EntityFramework.Contexts;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.DataAccess.Concrete.EntityFramework
{
    public class EfServiceDal : EfEntityRepositoryBase<Service, AcademicAgricultureContext>, IServiceDal
    {
    }
}
