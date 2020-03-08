﻿using AcademicAgriculture.Web.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models.Users
{
    public class RegisterViewModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        //public string ConfirmPassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Guid RoleId { get; set; }

        public List<CustomIdentityRole> Roles { get; internal set; }
    }
}