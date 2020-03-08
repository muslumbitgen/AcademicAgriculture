using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int blogId);
        Blog GetById(int blogId);

    }
}
