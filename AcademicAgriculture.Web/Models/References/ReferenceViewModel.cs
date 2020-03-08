using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.References
{
    public class ReferenceViewModel
    {
        public Reference Reference { get; set; }
        public List<Reference> References { get; set; }

    }
}
