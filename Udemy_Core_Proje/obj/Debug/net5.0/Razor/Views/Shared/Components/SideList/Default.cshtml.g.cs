#pragma checksum "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Shared\Components\SideList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56861e19f945b239b35d9758a55ac6bc4a859373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideList/Default.cshtml")]
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
#line 1 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\_ViewImports.cshtml"
using Udemy_Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\_ViewImports.cshtml"
using Udemy_Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56861e19f945b239b35d9758a55ac6bc4a859373", @"/Views/Shared/Components/SideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1efa055cdab479a4d5c64896c58d12314706172", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/faces/face12.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""col-md-6 col-xl-4 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Resimleri</h4>
                <div class=""owl-carousel owl-theme full-width owl-carousel-dash portfolio-carousel""  id=""owl-carousel-basic"">
");
#nullable restore
#line 7 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Shared\Components\SideList\Default.cshtml"
                     foreach(var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 454, "\"", 474, 1);
#nullable restore
#line 9 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Shared\Components\SideList\Default.cshtml"
WriteAttributeValue("", 460, item.ImageUrl, 460, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 475, "\"", 481, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"200\">\r\n                    </div> \r\n");
#nullable restore
#line 11 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Shared\Components\SideList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                </div>
                <div class=""d-flex py-4"">
                    <div class=""preview-list w-100"">
                        <div class=""preview-item p-0"">
                            <div class=""preview-thumbnail"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56861e19f945b239b35d9758a55ac6bc4a8593736334", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""preview-item-content d-flex flex-grow"">
                                <div class=""flex-grow"">
                                    <div class=""d-flex d-md-block d-xl-flex justify-content-between"">
                                        <h6 class=""preview-subject"">Yunus Kalyoncu</h6>
                                        <p class=""text-muted text-small"">Son Proje Resimleri</p>
                                    </div>
                                    <p class=""text-muted"">Yapılan Projeler ASP.net Core ve MVC olarak Yapılmıştır.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <p class=""text-muted"">Her Adım Yeni Bir Başlangıçtır... </p>
                <div class=""progress progress-md portfolio-progress"">
                    <div class=""progress-bar bg-success"" role=""progressbar"" style=""wi");
            WriteLiteral("dth: 50%\" aria-valuenow=\"25\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
