using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Services
{
    public class ServiceViewModel
    {
        public Service Service { get; set; }
        public List<Service> Services { get; set; }

    }
}
