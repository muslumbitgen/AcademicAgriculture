using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetList();
        }


        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public void Delete(int blogId)
        {
            _blogDal.Delete(new Blog { Id = blogId });
        }
        public Blog GetById(int blogId)
        {
            return _blogDal.Get(p => p.Id == blogId);
        }
    }
}
