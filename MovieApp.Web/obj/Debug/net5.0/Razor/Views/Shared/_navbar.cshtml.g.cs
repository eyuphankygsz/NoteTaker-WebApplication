#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_navbar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6cfaacdbf45e4ccaf39f27ea605063e09b96e9c90e2a436cbb9a8b4bc0c968cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6cfaacdbf45e4ccaf39f27ea605063e09b96e9c90e2a436cbb9a8b4bc0c968cf", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ef0be5e0b2e3ec04143093e60bc9ee7a0fc87056b5aec266a22b87e01be55967", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg nav-background fixed-top"">
	<div class=""container-fluid nav-background"">
		<a class=""navbar-brand logo"" href=""http://localhost:39939/"">MemoMate</a>
		<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
			<span class=""navbar-toggler-icon""></span>
		</button>
		<div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
			<ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
				<li class=""nav-item"">
					<a class=""nav-link active"" aria-current=""page""");
            BeginWriteAttribute("href", " href=\"", 651, "\"", 685, 1);
            WriteAttributeValue("", 658, 
#nullable restore
#line 10 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_navbar.cshtml"
                                                           Url.Action("Index","Home")

#line default
#line hidden
#nullable disable
            , 658, 27, false);
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t<a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 759, "\"", 794, 1);
            WriteAttributeValue("", 766, 
#nullable restore
#line 13 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_navbar.cshtml"
                                Url.Action("Index","About")

#line default
#line hidden
#nullable disable
            , 766, 28, false);
            EndWriteAttribute();
            WriteLiteral(">About</a>\r\n\t\t\t\t</li>\r\n\t\t\t</ul>\r\n\t\t\t<div id=\"guestNav\">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 858, "\"", 896, 1);
            WriteAttributeValue("", 865, 
#nullable restore
#line 17 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_navbar.cshtml"
              Url.Action("Index","Register")

#line default
#line hidden
#nullable disable
            , 865, 31, false);
            EndWriteAttribute();
            WriteLiteral(" id=\"signupbuttonlink\"> <button class=\"btn logbtn ms-2\" id=\"nav-signUpButton\" type=\"button\">Sign Up</button> </a>\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</nav>\r\n\r\n<script src=\"/js/navbar.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
