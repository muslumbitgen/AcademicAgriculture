using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using AcademicAgriculture.Web.Models;

namespace AcademicAgriculture.Web.Controllers
{
    public class SendMailController : Controller
    {
        [HttpPost]
        public void Index(Feedback feedback)
        {
            ViewBag.message = "sd";
        }
    }
}