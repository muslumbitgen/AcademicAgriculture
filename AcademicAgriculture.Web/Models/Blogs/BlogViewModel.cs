﻿using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Blogs
{
    public class BlogViewModel
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}