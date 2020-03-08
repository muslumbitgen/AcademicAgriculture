using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class ContentManager : IContentService
    {
        private IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void Add(Content content)
        {
            _contentDal.Add(content);
        }

        public void Delete(int contentId)
        {
            _contentDal.Delete(new Content { Id = contentId });
        }

        public List<Content> GetAll()
        {
            return _contentDal.GetList();
        }

        public Content GetById(int contentId)
        {
            return _contentDal.Get(p => p.Id == contentId);
        }

        public void Update(Content content)
        {
            _contentDal.Update(content);
        }
    }
}
