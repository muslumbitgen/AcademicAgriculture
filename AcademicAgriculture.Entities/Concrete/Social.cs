using AcademicAgriculture.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcademicAgriculture.Entities.Concrete
{
    [Table("Socials")]
    public class Social : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string TypeClass { get; set; }
        public string Url { get; set; }

    }
}
