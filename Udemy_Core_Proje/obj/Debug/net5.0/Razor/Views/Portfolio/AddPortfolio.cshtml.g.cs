#pragma checksum "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76266c81a5e83f0f9d45cd081b7b738b58b68457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76266c81a5e83f0f9d45cd081b7b738b58b68457", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1efa055cdab479a4d5c64896c58d12314706172", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/vendors/js/vendor.bundle.base.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> Proje Ekleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 8 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
 using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))

{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje İsmi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Resmi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Adresi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Kullanılan Icon"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Platform, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 29 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Kullanılırlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Status, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 34 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Referans Resimleri 1 "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Image1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 38 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Referans Resimleri 2 "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Image2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 41 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Referans Resimleri 3 "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Image3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 44 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Referans Resimleri 4 "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Image4, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 47 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Oranı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\" btn btn-primary\">Kayıt Et</button>\r\n    <button href=\"/Portfolio/Index/\" class=\" btn btn-outline-danger\">Çıkış</button>\r\n");
#nullable restore
#line 52 "C:\Users\yunus\source\repos\Udemy_Core_Proje\Udemy_Core_Proje\Views\Portfolio\AddPortfolio.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76266c81a5e83f0f9d45cd081b7b738b58b6845711344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
