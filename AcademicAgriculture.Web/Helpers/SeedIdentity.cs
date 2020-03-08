using AcademicAgriculture.Web.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Helpers
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, IConfiguration configuration)
        {
            var fullname = configuration["Data:AdminUser:fullname"];
            var username = configuration["Data:AdminUser:username"];
            var password = configuration["Data:AdminUser:password"];
            var email = configuration["Data:AdminUser:email"];
            var rol = configuration["Data:AdminUser:role"];

            var userControl = await userManager.FindByEmailAsync(email);
            if (userControl == null)
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    FullName = fullname,
                    UserName = username,
                    Email = email,
                    RolName = rol,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                };

                IdentityResult result = userManager.CreateAsync(user, password).Result;
                if (result.Succeeded)
                {
                    if (!roleManager.RoleExistsAsync("Admin").Result)
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "Admin"
                        };
                        IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                        if (!roleResult.Succeeded)
                        {
                            return;
                        }
                    }
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }


            }
        }
    }
}
