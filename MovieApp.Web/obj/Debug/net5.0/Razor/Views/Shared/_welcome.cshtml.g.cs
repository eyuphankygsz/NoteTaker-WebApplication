#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_welcome.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92cb6000a45f3d06594178d4096b277be7bf600a3812383b4b6d1bc163898e18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__welcome), @"mvc.1.0.view", @"/Views/Shared/_welcome.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.GeneralHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models.Posts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"92cb6000a45f3d06594178d4096b277be7bf600a3812383b4b6d1bc163898e18", @"/Views/Shared/_welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"551a3915c97d0c6e79dc14e84bc521a5b2e0c70180d8746e3ad102c5321891b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserEntity>
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
				<input class=""form-control form-control-sm"" type=""search"" placeholder=""Search"" />
				<div id=""search-items"">
				</div>
			</div>
			<div class=""user align-items-center"">
				<img class=""h-100""");
            BeginWriteAttribute("src", " src=\"", 490, "\"", 526, 2);
            WriteAttributeValue("", 496, "/img/user/profile/", 496, 18, true);
#nullable restore
#line 15 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_welcome.cshtml"
WriteAttributeValue("", 514, Model.Photo, 514, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"welcome-greeting\">\r\n\t\t<div class=\"welcome-name d-flex\">\r\n\t\t\t<span class=\"text-white fw-bold\">Hello, ");
#nullable restore
#line 22 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_welcome.cshtml"
                                               Write(Model.Username);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserEntity> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
