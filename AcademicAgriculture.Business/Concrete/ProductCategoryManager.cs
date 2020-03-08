using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class ProductCategoryManager : IProductCategoryService
    {
        private IProductCategoryDal _productCategoryDal;

        public ProductCategoryManager(IProductCategoryDal productCategoryDal)
        {
            _productCategoryDal = productCategoryDal;
        }

        public void Add(ProductCategory productCategory)
        {
            _productCategoryDal.Add(productCategory);
        }

        public void Delete(int productCategoryId)
        {
            _productCategoryDal.Delete(new ProductCategory { Id = productCategoryId });
        }

        public List<ProductCategory> GetAll()
        {
            return _productCategoryDal.GetList();
        }

        public ProductCategory GetById(int productCategoryId)
        {
            return _productCategoryDal.Get(p => p.Id == productCategoryId);
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategoryDal.Update(productCategory);
        }
    }
}
