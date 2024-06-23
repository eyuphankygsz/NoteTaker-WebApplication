#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Register\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cfe34d2930ecc4b4b04699c0e5290942902125c7e7ee4c9a4d25c47d56c1becb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Data;

#nullable disable
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Controllers;

#nullable disable
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models;

#nullable disable
#nullable restore
#line 4 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.GeneralHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cfe34d2930ecc4b4b04699c0e5290942902125c7e7ee4c9a4d25c47d56c1becb", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ef0be5e0b2e3ec04143093e60bc9ee7a0fc87056b5aec266a22b87e01be55967", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserRegisterModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/register.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfe34d2930ecc4b4b04699c0e5290942902125c7e7ee4c9a4d25c47d56c1becb4518", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
#nullable restore
#line 6 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Register\Index.cshtml"
  
	Layout = "_MainLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"main\">\r\n\t<form class=\"register-container\" asp-action=\"Index\" method=\"post\">\r\n\t\t<h2 class=\"text-center mb-4\">Register</h2>\r\n\t\t<div class=\"input-group mb-3\">\r\n\t\t\t<span class=\"input-group-text\" id=\"basic-addon1\">");
            WriteLiteral(@"@</span>
			<input type=""text"" asp-for=""Username"" name=""Username"" class=""form-control username"" placeholder=""JohnDoe"" aria-label=""Username"" aria-describedby=""basic-addon1"">
		</div>

		<div class=""input-group mb-3"">
			<input type=""text"" asp-for=""Mail"" name=""Mail"" class=""form-control mail"" id=""mail1"" placeholder=""Mail Adress"" aria-label=""Mail Adress"" aria-describedby=""basic-addon2"">
		</div>
		<div class=""input-group mb-3"">
			<input type=""text"" class=""form-control mail"" id=""mail2"" placeholder=""Mail Adress Confirm"" aria-label=""Mail Adress"" aria-describedby=""basic-addon2"">
		</div>
		<div class=""input-group mb-3"">
			<input type=""password"" asp-for=""Password"" name=""Password"" class=""form-control password"" id=""password1"" placeholder=""Password"" aria-describedby=""basic-addon3"">
		</div>
		<div class=""input-group mb-3"">
			<input type=""password"" class=""form-control password"" id=""password2"" placeholder=""Password Confirm"" aria-describedby=""basic-addon3"">
		</div>
		<div class=""input-group mb-3"">
			<b");
            WriteLiteral("utton class=\"btn btn-danger m-auto w-75\" id=\"submitButton\">Register</button>\r\n\t\t</div>\r\n\r\n\t</form>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t\t\t\t<script src=\"/js/register.js\"></script>\r\n\t\t\t");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserRegisterModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
