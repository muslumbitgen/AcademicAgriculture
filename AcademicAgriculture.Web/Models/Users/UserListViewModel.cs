using AcademicAgriculture.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Users
{
    public class UserListViewModel
    {
        public List<CustomIdentityUser> Users { get; internal set; }

    }
}
