#pragma checksum "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Admin\PartialHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c358452bc67868b33de0520b3bf0fbbd0c0e01d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialHeader), @"mvc.1.0.view", @"/Views/Admin/PartialHeader.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c358452bc67868b33de0520b3bf0fbbd0c0e01d9", @"/Views/Admin/PartialHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1efa055cdab479a4d5c64896c58d12314706172", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">");
#nullable restore
#line 6 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Admin\PartialHeader.cshtml"
                                                             Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
                            <li class=""breadcrumb-item""><a href=""#"">");
#nullable restore
#line 10 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Admin\PartialHeader.cshtml"
                                                               Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 11 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Admin\PartialHeader.cshtml"
                                                                              Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ol>\r\n                    </nav>\r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
