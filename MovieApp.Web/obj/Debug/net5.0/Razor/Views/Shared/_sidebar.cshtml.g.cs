#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a0fcbc9c626c236d462959077afbe5d90a856b93d9beeeb9c048f3931b8a0cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__sidebar), @"mvc.1.0.view", @"/Views/Shared/_sidebar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a0fcbc9c626c236d462959077afbe5d90a856b93d9beeeb9c048f3931b8a0cdb", @"/Views/Shared/_sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"551a3915c97d0c6e79dc14e84bc521a5b2e0c70180d8746e3ad102c5321891b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SidebarModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"d-flex flex-column flex-shrink-0 custom-sidebar sticky-top\" style=\"width: 4.5rem;\">\r\n\t<img src=\"/img/logo.png\" />\r\n\t<ul class=\"nav nav-pills nav-flush flex-column mb-auto text-center\">\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 251, "\"", 286, 1);
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 258, Url.Action("Index","Posts"), 258, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link active py-3 border-bottom\" id=\"side-home\">\r\n\t\t\t\t<i class=\"fa-solid fa-house fa-xl\"></i>\r\n\t\t\t</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 441, "\"", 476, 1);
#nullable restore
#line 12 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 448, Url.Action("Rates","Posts"), 448, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link py-3 border-bottom position-relative\" id=\"side-rate\"");
            BeginWriteAttribute("title", " title=\"", 546, "\"", 554, 0);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\" data-bs-original-title=\"Dashboard\">\r\n\t\t\t\t<i class=\"fa-solid fa-star-half-stroke fa-xl\"></i>\r\n");
#nullable restore
#line 14 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
                  
					string count = GetNewPostCount();
					if (!string.IsNullOrEmpty(count))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span class=\"position-absolute badge rounded-pill bg-danger\" style=\"top:10%; left: 65%; font-size: 0.6rem;\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 19 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 21 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
					}
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1009, "\"", 1045, 1);
#nullable restore
#line 28 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 1016, Url.Action("Create","Posts"), 1016, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link py-3 border-bottom\" id=\"side-create\"");
            BeginWriteAttribute("title", " title=\"", 1099, "\"", 1107, 0);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\" data-bs-original-title=\"Orders\">\r\n\t\t\t\t<i class=\"fa-solid fa-square-plus fa-xl\"></i>\r\n\t\t\t</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1293, "\"", 1328, 1);
#nullable restore
#line 33 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 1300, Url.Action("Likes", "User"), 1300, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link active py-3 border-bottom\" id=\"side-likes\">\r\n\t\t\t\t<i class=\"fa-solid fa-heart fa-xl\"></i>\r\n\t\t\t</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1484, "\"", 1523, 1);
#nullable restore
#line 38 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 1491, Url.Action("Inbox", "Messages"), 1491, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link active py-3 border-bottom"" id=""side-likes"">
				<i class=""fa-solid fa-message fa-xl""></i>
			</a>
		</li>
	</ul>
	<div class=""dropdown border-top"">
		<a href=""#"" class=""d-flex align-items-center justify-content-center p-3 link-dark text-decoration-none dropdown-toggle"" id=""dropdownUser3"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
			<img");
            BeginWriteAttribute("src", " src=\"", 1893, "\"", 1946, 2);
            WriteAttributeValue("", 1899, "/img/user/profile/", 1899, 18, true);
#nullable restore
#line 45 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 1917, Model.LoggedUserEntity.Photo, 1917, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"mdo\" width=\"24\" height=\"24\" class=\"rounded-circle\">\r\n\t\t</a>\r\n\t\t<ul class=\"dropdown-menu text-small shadow\" aria-labelledby=\"dropdownUser3\">\r\n\t\t\t<li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 2125, "\"", 2209, 1);
#nullable restore
#line 48 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 2132, Url.Action("Settings", "User", new { id = Model.LoggedUserEntity.Username }), 2132, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Settings</a></li>\r\n\t\t\t<li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 2261, "\"", 2344, 1);
#nullable restore
#line 49 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 2268, Url.Action("Details", "User", new { id = Model.LoggedUserEntity.Username }), 2268, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Profile - ");
#nullable restore
#line 49 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
                                                                                                                                  Write(Model.LoggedUserEntity.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t<li><hr class=\"dropdown-divider\"></li>\r\n\t\t\t<li><a class=\"dropdown-item\" id=\"signout\"");
            BeginWriteAttribute("href", " href=\"", 2486, "\"", 2522, 1);
#nullable restore
#line 51 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
WriteAttributeValue("", 2493, Url.Action("Logout", "User"), 2493, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sign out</a></li>\r\n\t\t</ul>\r\n\t</div>\r\n</div>\r\n\r\n<script src=\"/js/sidebar.js\"></script>\r\n\r\n\r\n");
#nullable restore
#line 59 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_sidebar.cshtml"
  
	string GetNewPostCount()
	{
		return Model.NewPostCount > 99 ? "99+" :
						Model.NewPostCount == 0 ? null :
						Model.NewPostCount.ToString();
	}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SidebarModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
