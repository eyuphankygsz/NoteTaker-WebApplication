#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6221ed26af3adf685ab37a886cbed7263110e52076a407310a7b19572c27356b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__bottombar), @"mvc.1.0.view", @"/Views/Shared/_bottombar.cshtml")]
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
using MemoMate.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6221ed26af3adf685ab37a886cbed7263110e52076a407310a7b19572c27356b", @"/Views/Shared/_bottombar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"df36c760b636adba1a95ca388a2562bed9818eb52a1c53ef12e60a1a4dbf5f10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__bottombar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<nav class=\"navbar fixed-bottom navbar-expand-sm navbar-dark bg-dark border-bottom-0\">\r\n\t<ul class=\"navbar-nav mr-auto\">\r\n\t\t<li class=\"nav-item active\">\r\n<<<<<<< HEAD\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 188, "\"", 223, 1);
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml"
WriteAttributeValue("", 195, Url.Action("Rates","Posts"), 195, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link py-2 border-bottom\" id=\"side-rate\"");
            BeginWriteAttribute("title", " title=\"", 275, "\"", 283, 0);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\" data-bs-original-title=\"Dashboard\">\r\n=======\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 387, "\"", 422, 1);
#nullable restore
#line 9 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml"
WriteAttributeValue("", 394, Url.Action("Rates","Posts"), 394, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link border-bottom\" id=\"bottom-rate\"");
            BeginWriteAttribute("title", " title=\"", 471, "\"", 479, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""tooltip"" data-bs-placement=""right"" data-bs-original-title=""Dashboard"">
>>>>>>> 86211ef1167d5ab6053237bb4d22cd42a03f9338
				<i class=""fa-solid fa-star-half-stroke fa-xl""></i>
			</a>
		</li>
		<li class=""nav-item"">
<<<<<<< HEAD
			<a");
            BeginWriteAttribute("href", " href=\"", 737, "\"", 772, 1);
#nullable restore
#line 16 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml"
WriteAttributeValue("", 744, Url.Action("Index","Posts"), 744, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link active py-2 border-bottom\" id=\"side-home\" aria-current=\"page\"");
            BeginWriteAttribute("title", " title=\"", 851, "\"", 859, 0);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\" data-bs-original-title=\"Home\">\r\n=======\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 958, "\"", 993, 1);
#nullable restore
#line 18 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml"
WriteAttributeValue("", 965, Url.Action("Index","Posts"), 965, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link active border-bottom\" id=\"bottom-home\" aria-current=\"page\"");
            BeginWriteAttribute("title", " title=\"", 1069, "\"", 1077, 0);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\" data-bs-original-title=\"Home\">\r\n>>>>>>> 86211ef1167d5ab6053237bb4d22cd42a03f9338\r\n\t\t\t\t<i class=\"fa-solid fa-house fa-xl\"></i>\r\n\t\t\t</a>\r\n\t\t</li>\r\n\t\t<li class=\"nav-item\">\r\n<<<<<<< HEAD\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1319, "\"", 1355, 1);
#nullable restore
#line 25 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml"
WriteAttributeValue("", 1326, Url.Action("Create","Posts"), 1326, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link py-2 border-bottom\" id=\"side-create\"");
            BeginWriteAttribute("title", " title=\"", 1409, "\"", 1417, 0);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\" data-bs-original-title=\"Orders\">\r\n=======\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1518, "\"", 1554, 1);
#nullable restore
#line 27 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml"
WriteAttributeValue("", 1525, Url.Action("Create","Posts"), 1525, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link  border-bottom\" id=\"bottom-create\"");
            BeginWriteAttribute("title", " title=\"", 1606, "\"", 1614, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""tooltip"" data-bs-placement=""right"" data-bs-original-title=""Orders"">
>>>>>>> 86211ef1167d5ab6053237bb4d22cd42a03f9338
				<i class=""fa-solid fa-square-plus fa-xl""></i>
			</a>
		</li>
		<li class=""nav-item"">
<<<<<<< HEAD
			<a href=""#"" class=""nav-link py-2 border-bottom"" id=""dropdownUser3"" data-bs-toggle=""tooltip"" aria-expanded=""false"">
=======
			<a href=""#"" class=""nav-link border-bottom"" id=""dropdownUser3"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
>>>>>>> 86211ef1167d5ab6053237bb4d22cd42a03f9338
				<img");
            BeginWriteAttribute("src", " src=\"", 2160, "\"", 2196, 2);
            WriteAttributeValue("", 2166, "/img/user/profile/", 2166, 18, true);
#nullable restore
#line 38 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_bottombar.cshtml"
WriteAttributeValue("", 2184, Model.Photo, 2184, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"mdo\" width=\"24\" height=\"24\" class=\"rounded-circle\">\r\n\t\t\t</a>\r\n\t\t</li>\r\n\t</ul>\r\n</nav>\r\n\r\n<script src=\"./js/sidebar.js\"></script>");
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
