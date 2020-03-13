using AcademicAgriculture.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.DataAccess.Concrete.EntityFramework.Contexts
{
   public  class AcademicAgricultureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=94.73.146.5;Database=Academi; Uid=userD32;Pwd=KBsq78K2ROjv10Q;");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<OurNumber> OurNumbers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Reference> References { get; set; }
    }
}
