using AcademicAgriculture.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcademicAgriculture.Entities.Concrete
{
    [Table("Blogs")]
    public class Blog : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

    }
}
