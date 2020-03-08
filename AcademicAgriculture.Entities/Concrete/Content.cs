using AcademicAgriculture.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcademicAgriculture.Entities.Concrete
{
    [Table("Contents")]
    public class Content : BaseEntity, IEntity
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
