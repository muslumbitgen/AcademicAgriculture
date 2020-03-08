using AcademicAgriculture.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcademicAgriculture.Entities.Concrete
{
    [Table("Abouts")]
    public class About : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
