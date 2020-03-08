using AcademicAgriculture.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcademicAgriculture.Entities.Concrete
{
    [Table("OurNumbers")]
    public class OurNumber : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Number { get; set; }

    }
}
