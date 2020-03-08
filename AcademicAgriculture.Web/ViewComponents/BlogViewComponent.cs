using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Web.Models.Blogs;
using AcademicAgriculture.Web.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicAgriculture.Web.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private IBlogService _blogService;
        public BlogViewComponent(IBlogService blogService)
        {
            _blogService = blogService;

        }
        public ViewViewComponentResult Invoke()
        {
            var blogs = _blogService.GetAll().Where(x => x.IsActive == true);
            BlogListViewModel model = new BlogListViewModel
            {
                Blogs = blogs.ToList()
            };
            return View(model);
        }
    }
}
