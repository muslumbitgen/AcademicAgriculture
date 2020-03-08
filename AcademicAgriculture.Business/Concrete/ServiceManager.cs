using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        private IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service service)
        {
            _serviceDal.Add(service);
        }

        public void Delete(int serviceId)
        {
            _serviceDal.Delete(new Service { Id = serviceId });
        }

        public List<Service> GetAll()
        {
            return _serviceDal.GetList();
        }

        public Service GetById(int serviceId)
        {
            return _serviceDal.Get(p => p.Id == serviceId);
        }

        public void Update(Service service)
        {
            _serviceDal.Update(service);
        }
    }
}
