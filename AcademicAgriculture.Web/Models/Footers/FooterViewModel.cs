using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Footers
{
    public class FooterViewModel
    {
        public Content Content { get; set; }
        public About About { get; set; }
        public List<Service> Services { get; set; }
        public List<Social> Socials { get; set; }
    }
}
