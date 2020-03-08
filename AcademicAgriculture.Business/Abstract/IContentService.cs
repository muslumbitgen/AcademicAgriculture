using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface IContentService
    {
        List<Content> GetAll();
        void Add(Content content);
        void Update(Content content);
        void Delete(int contentId);
        Content GetById(int contentId);
    }
}
