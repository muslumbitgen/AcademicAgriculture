using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }
        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.ProductCategoryId == categoryId);
        }
        public void Delete(int productId)
        {
            _productDal.Delete(new Product { Id = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.Id == productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
