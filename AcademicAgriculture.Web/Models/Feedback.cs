using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.Models
{
    public class Feedback
    {
        public string AdSoyad { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public string Konu { get; set; }

        public string Mesaj { get; set; }
    }
}
