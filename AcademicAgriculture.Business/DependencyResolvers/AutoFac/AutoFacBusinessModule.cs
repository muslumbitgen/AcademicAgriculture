using AcademicAgriculture.Business.Abstract;
using AcademicAgriculture.Business.Concrete;
using AcademicAgriculture.DataAccess.Abstract;
using AcademicAgriculture.DataAccess.Concrete.EntityFramework;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademicAgriculture.Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlogManager>().As<IBlogService>();
            builder.RegisterType<EfBlogDal>().As<IBlogDal>();

            builder.RegisterType<SliderManager>().As<ISliderService>();
            builder.RegisterType<EfSliderDal>().As<ISliderDal>();

            builder.RegisterType<ServiceManager>().As<IServiceService>();
            builder.RegisterType<EfServiceDal>().As<IServiceDal>();

            builder.RegisterType<AboutManager>().As<IAboutService>();
            builder.RegisterType<EfAboutDal>().As<IAboutDal>();  
            
            builder.RegisterType<OurNumberManager>().As<IOurNumberService>();
            builder.RegisterType<EfOurNumberDal>().As<IOurNumberDal>();
            
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<ProductCategoryManager>().As<IProductCategoryService>();
            builder.RegisterType<EfProductCategoryDal>().As<IProductCategoryDal>();

            builder.RegisterType<ContentManager>().As<IContentService>();
            builder.RegisterType<EfContentDal>().As<IContentDal>();

            builder.RegisterType<SocialManager>().As<ISocialService>();
            builder.RegisterType<EfSocialDal>().As<ISocialDal>(); 
            
            builder.RegisterType<ReferenceManager>().As<IReferenceService>();
            builder.RegisterType<EfReferenceDal>().As<IReferenceDal>();
        }
    }
}
