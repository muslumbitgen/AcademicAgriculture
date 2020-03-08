using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Entities
{
    public class CustomIdentityUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public Guid RoleId { get; set; }
        public string RolName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
