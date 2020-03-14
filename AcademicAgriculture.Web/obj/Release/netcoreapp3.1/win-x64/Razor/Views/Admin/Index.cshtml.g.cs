#pragma checksum "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5bc3207f64f3f8fa7d6681de1dc73315b8d335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\_ViewImports.cshtml"
using AcademicAgriculture.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\_ViewImports.cshtml"
using AcademicAgriculture.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5bc3207f64f3f8fa7d6681de1dc73315b8d335", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a489ca1ca85e7066b6853e0d7f19dab2381da7fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AcademicAgriculture.Web.Models.AdminCount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Admin\Index.cshtml"
  
    ViewData["Page"] = "Anasayfa";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row gutter-xs"">
    <div class=""col-md-6 col-lg-3 col-lg-push-0"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""media"">
                    <div class=""media-middle media-left"">
                        <span class=""bg-primary circle sq-48"">
                            <span class=""icon icon-user""></span>
                        </span>
                    </div>
                    <div class=""media-middle media-body"">
                        <h6 class=""media-heading"">Kullanıcı Sayısı</h6>
                        <h3 class=""media-heading"">
                            <span class=""fw-l"">");
#nullable restore
#line 19 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Admin\Index.cshtml"
                                          Write(Model.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </h3>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3 col-lg-push-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""media"">
                    <div class=""media-middle media-left"">
                        <span class=""bg-danger circle sq-48"">
                            <span class=""icon icon-shopping-bag""></span>
                        </span>
                    </div>
                    <div class=""media-middle media-body"">
                        <h6 class=""media-heading"">Ürün Sayısı</h6>
                        <h3 class=""media-heading"">
                            <span class=""fw-l"">");
#nullable restore
#line 38 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Admin\Index.cshtml"
                                          Write(Model.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </h3>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3 col-lg-pull-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""media"">
                    <div class=""media-middle media-left"">
                        <span class=""bg-primary circle sq-48"">
                            <span class=""icon icon-newspaper-o""></span>
                        </span>
                    </div>
                    <div class=""media-middle media-body"">
                        <h6 class=""media-heading"">Haber Sayısı</h6>
                        <h3 class=""media-heading"">
                            <span class=""fw-l"">");
#nullable restore
#line 57 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Admin\Index.cshtml"
                                          Write(Model.BlogCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </h3>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3 col-lg-pull-0"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""media"">
                    <div class=""media-middle media-left"">
                        <span class=""bg-danger circle sq-48"">
                            <span class=""icon icon-usd""></span>
                        </span>
                    </div>
                    <div class=""media-middle media-body"">
                        <h6 class=""media-heading"">Total Sales</h6>
                        <h3 class=""media-heading"">
                            <span class=""fw-l"">$155,352.47</span>
                        </h3>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcademicAgriculture.Web.Models.AdminCount> Html { get; private set; }
    }
}
#pragma warning restore 1591
