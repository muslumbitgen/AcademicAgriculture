#pragma checksum "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793dba5744b5142b7e20daed8389b10fa489802c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slider_Index), @"mvc.1.0.view", @"/Views/Slider/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793dba5744b5142b7e20daed8389b10fa489802c", @"/Views/Slider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a489ca1ca85e7066b6853e0d7f19dab2381da7fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Slider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<AcademicAgriculture.Entities.Concrete.Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm btn-labeled mr-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
  
    ViewData["Page"] = "Slider Listesi";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793dba5744b5142b7e20daed8389b10fa489802c5657", async() => {
                WriteLiteral(@"
            <div class=""hidden-xs hidden-sm p0-10"">
                <span class=""btn-label"">
                    <span class=""icon icon-plus icon-lg icon-fw""></span>
                </span>
                <span>Yeni</span>
            </div>
            <icon class=""hidden-lg hidden-md btn icon icon-plus""></icon>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""card-body p-t-0"">
        <div class=""card-body"">
            <table id=""demo-datatables-colreorder-2"" class=""table table-hover table-striped table-bordered table-nowrap dataTable"" cellspacing=""0"" width=""100%"">
                <thead>
                    <tr>
                        <td>işlem</td>
                        <td>Başlık</td>
                        <td>Durum</td>
                        <td>Resim</td>
                        <td>Açıklama</td>
                        <td>Oluşturma Tarihi</td>
                        <td>Güncelleme Tarihi</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 35 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                     foreach (var slider in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793dba5744b5142b7e20daed8389b10fa489802c8483", async() => {
                WriteLiteral("<icon class=\"icon icon-edit\"></icon>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                                                                                                         WriteLiteral(slider.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a class=\"btn btn-xs btn-danger btndel\" data-id=\"");
#nullable restore
#line 40 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                                                                        Write(slider.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-controller=\"Slider\" data-message=\"Slider\"><icon class=\"icon icon-trash\"></icon></a>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                       Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 1948, "\"", 1990, 2);
#nullable restore
#line 43 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
WriteAttributeValue("", 1956, slider.Id, 1956, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1966, "??Slider??IsActiveSlider", 1966, 24, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1991, "\"", 2063, 4);
            WriteAttributeValue("", 1999, "btn", 1999, 3, true);
            WriteAttributeValue(" ", 2002, "btn-", 2003, 5, true);
#nullable restore
#line 43 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
WriteAttributeValue("", 2007, slider.IsActive == true ? "success" : "danger", 2007, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2056, "btn-sm", 2057, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                                                                                                                                                                  Write(slider.IsActive == true ? "Aktif" : "Pasif");

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "793dba5744b5142b7e20daed8389b10fa489802c13365", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2195, "~/img/", 2195, 6, true);
#nullable restore
#line 45 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
AddHtmlAttributeValue("", 2201, slider.Url, 2201, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                       Write(slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                       Write(slider.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                       Write(slider.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\Projects\AcademicAgriculture\AcademicAgriculture.Web\Views\Slider\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<AcademicAgriculture.Entities.Concrete.Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
