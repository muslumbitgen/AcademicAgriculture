using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcademicAgriculture.Entities.Concrete
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; } = false;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
