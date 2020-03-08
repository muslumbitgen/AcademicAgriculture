using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Contents
{
    public class ContentViewModel
    {
        public Content Content { get; set; }
        public Feedback Feedback { get; set; }

    }
}
