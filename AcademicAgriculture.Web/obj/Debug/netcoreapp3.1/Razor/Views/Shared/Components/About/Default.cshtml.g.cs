#pragma checksum "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Shared\Components\About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5fc971c115c8c74fd658967e05de681164b094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/About/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5fc971c115c8c74fd658967e05de681164b094", @"/Views/Shared/Components/About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a489ca1ca85e7066b6853e0d7f19dab2381da7fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AcademicAgriculture.Web.Models.Abouts.AboutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""bestservice"">
    <div class=""container"">
        <div class=""fh-icon-box-2  radius"">
            <div class=""row"">
                <div class=""item-box col-md-4 col-sm-6 col-xs-12"">
                    <a href=""#"" target=""_self"" class=""fh-icon""><span><i class=""flaticon-people-1""></i></span></a>
                    <h4><a href=""#"" target=""_self"">DÜRÜSLÜK</a></h4>
                    <p>Verilen söze riayet.</p>
                </div>
                <div class=""item-box col-md-4 col-sm-6 col-xs-12"">
                    <a href=""#"" target=""_self"" class=""fh-icon""><span><i class=""flaticon-book-1""></i></span></a>
                    <h4><a href=""#"" target=""_self"">Akademik</a></h4>
                    <p>Akademik araştırma ile doğru yöntem.</p>
                </div>
                <div class=""item-box col-md-4 col-sm-6 col-xs-12"">
                    <a href=""gardenhub_theme.html"" target=""_self"" class=""fh-icon""><span><i class=""flaticon-multimedia""></i></span></a>
                    <h");
            WriteLiteral(@"4><a href=""gardenhub_theme.html"" target=""_self"">Ziraat ve Peysaj Yönetimi</a></h4>
                    <p>Kaliteli işin adresi</p>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""aboutsec3 secpadd"">
    <div class=""container"">
        <div class=""fh-section-title clearfix  text-center style-1 version-dark has-icon margbtm40"">
            <h2>Hakkımızda</h2>
            <span class=""fh-icon""><i class=""flaticon-nature-3""></i></span>
        </div>
        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""about3left"">
                    <p");
            BeginWriteAttribute("class", " class=\"", 1714, "\"", 1722, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 35 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Shared\Components\About\Default.cshtml"
                   Write(Model.About.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"about4rgt\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e5fc971c115c8c74fd658967e05de681164b0945981", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1953, "~/img/", 1953, 6, true);
#nullable restore
#line 41 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Shared\Components\About\Default.cshtml"
AddHtmlAttributeValue("", 1959, Model.About.Url, 1959, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcademicAgriculture.Web.Models.Abouts.AboutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
