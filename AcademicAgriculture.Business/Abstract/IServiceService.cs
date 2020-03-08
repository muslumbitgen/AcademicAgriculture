using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface IServiceService
    {
        List<Service> GetAll();
        void Add(Service service);
        void Update(Service service);
        void Delete(int serviceId);
        Service GetById(int serviceId);
    }
}
