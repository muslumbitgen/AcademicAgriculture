using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Abstract
{
    public interface IProductCategoryService
    {
        List<ProductCategory> GetAll();
        void Add(ProductCategory productCategory);
        void Update(ProductCategory productCategory);
        void Delete(int productCategoryId);
        ProductCategory GetById(int productCategoryId);
    }
}
