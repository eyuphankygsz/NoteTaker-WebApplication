#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_welcome.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2a9d371f0fb14283a592b9af31cd88b0811c1f54e0949a3fabdc7e4e0ef64e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__welcome), @"mvc.1.0.view", @"/Views/Shared/_welcome.cshtml")]
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

#nullable disable
#nullable restore
#line 5 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2a9d371f0fb14283a592b9af31cd88b0811c1f54e0949a3fabdc7e4e0ef64e62", @"/Views/Shared/_welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b31008db680e9423da7e6b4d478e42b926181cc1143b5eadf66e1636d591bfbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""welcome mx-4"">
	<div class=""welcome-nav d-flex justify-content-between h-100"">
		<div class=""breadcrumbs d-flex"">
			<span class=""text-white fw-bold m-auto"">Posts</span>
		</div>
		<div class=""navigation d-flex"">
			<div class=""searchbar m-auto"">
				<input class=""form-control form-control-sm"" type=""search"" />
				<button><i class=""fa-solid fa-magnifying-glass"" style=""color: #000000;""></i></button>
			</div>
			<div class=""user align-items-center"">
				<img class=""h-100""");
            BeginWriteAttribute("src", " src=\"", 513, "\"", 549, 2);
            WriteAttributeValue("", 519, "/img/user/profile/", 519, 18, true);
            WriteAttributeValue("", 537, 
#nullable restore
#line 14 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_welcome.cshtml"
                                               Model.Photo

#line default
#line hidden
#nullable disable
            , 537, 12, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"welcome-greeting\">\r\n\t\t<div class=\"welcome-name d-flex\">\r\n\t\t\t<span class=\"text-white fw-bold\">Hello, ");
            Write(
#nullable restore
#line 21 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_welcome.cshtml"
                                            Model.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div class=\"welcome-nexttheme d-block\">\r\n\t\t\t<span class=\"text-white\">Next Theme will be announced in</span>\r\n\t\t\t<p class=\"text-white welcome-nexttheme-time\"></p>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n<script src=\"/js/welcome.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
