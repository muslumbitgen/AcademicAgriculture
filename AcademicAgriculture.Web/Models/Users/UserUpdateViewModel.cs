using AcademicAgriculture.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Users
{
    public class UserUpdateViewModel
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid RoleId { get; set; }
        public List<CustomIdentityRole> Roles { get; internal set; }

    }
}
