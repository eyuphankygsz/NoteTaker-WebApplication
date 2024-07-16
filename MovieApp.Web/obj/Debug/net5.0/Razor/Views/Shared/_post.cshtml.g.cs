#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fa48cb663cd74af898716994a9c694ac4a27edadb53f4b0104250ce14c1d1b26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__post), @"mvc.1.0.view", @"/Views/Shared/_post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fa48cb663cd74af898716994a9c694ac4a27edadb53f4b0104250ce14c1d1b26", @"/Views/Shared/_post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b31008db680e9423da7e6b4d478e42b926181cc1143b5eadf66e1636d591bfbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostDetailModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"posts-card card text-center mb-3 h-100 shadow\">\r\n\t<div class=\"card-header \">\r\n\t\t<a class=\"d-flex align-items-center\"");
            BeginWriteAttribute("href", " href=\"", 154, "\"", 220, 1);
            WriteAttributeValue("", 161, 
#nullable restore
#line 5 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                              Url.Action("Details", "User", new { id = Model.Username })

#line default
#line hidden
#nullable disable
            , 161, 59, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t<div class=\"post-profile d-flex justify-content-center\">\r\n\t\t\t\t<img class=\"h-100\"");
            BeginWriteAttribute("src", " src=\"", 307, "\"", 347, 2);
            WriteAttributeValue("", 313, "/img/user/profile/", 313, 18, true);
            WriteAttributeValue("", 331, 
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                               Model.UserPhoto

#line default
#line hidden
#nullable disable
            , 331, 16, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\t\t\t</div>\r\n\t\t\t");
            Write(
#nullable restore
#line 9 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
    Model.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t</a>\r\n");
#nullable restore
#line 11 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
    
			if (Model.CanInteract && !Model.IsOwned)
			{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t<button class=\"follow-user ms-2\" data-post-id=\"");
            Write(
#nullable restore
#line 14 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                                    Model.PostID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\"><i");
            BeginWriteAttribute("class", " class=\"", 538, "\"", 576, 3);
            WriteAttributeValue("", 546, "fa-solid", 546, 8, true);
            WriteAttributeValue(" ", 554, 
#nullable restore
#line 14 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                                                                      Model.IsFriend

#line default
#line hidden
#nullable disable
            , 555, 15, false);
            WriteAttributeValue(" ", 570, "fa-lg", 571, 6, true);
            EndWriteAttribute();
            WriteLiteral("></i></button>\r\n");
#nullable restore
#line 15 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
			}
		

#line default
#line hidden
#nullable disable

            WriteLiteral("\t</div>\r\n\t<div class=\"card-body\">\r\n\t\t<div class=\"card-content\">\r\n\t\t\t<h5 class=\"card-title\">");
            Write(
#nullable restore
#line 20 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                           Model.NoteTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n\t\t\t<p class=\"card-text\">");
            Write(
#nullable restore
#line 21 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                         Model.NoteContent

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\t\t</div>\r\n\t\t<div class=\"card-theme\">");
            Write(
#nullable restore
#line 23 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                           Model.ThemeName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n\t</div>\r\n\t<div class=\"card-footer d-flex justify-content-between text-body-secondary\">\r\n\t\t<span class=\"rate text-white fw-bold\">★ ");
            Write(
#nullable restore
#line 26 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                           Model.PostRate.ToString("0.00")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
    
			if (Model.CanInteract)
			{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t<div class=\"post-interactions\">\r\n\t\t\t\t\t<button class=\"like-post\" data-post-id=\"");
            Write(
#nullable restore
#line 31 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                              Model.PostID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\"><i");
            BeginWriteAttribute("class", " class=\"", 1135, "\"", 1183, 4);
            WriteAttributeValue("", 1143, "fa-solid", 1143, 8, true);
            WriteAttributeValue(" ", 1151, "fa-thumbs-up", 1152, 13, true);
            WriteAttributeValue(" ", 1164, "fa-xl", 1165, 6, true);
            WriteAttributeValue(" ", 1170, 
#nullable restore
#line 31 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                                                                                   Model.Liked

#line default
#line hidden
#nullable disable
            , 1171, 12, false);
            EndWriteAttribute();
            WriteLiteral("></i></button>\r\n\t\t\t\t\t<button class=\"share-post\"><i class=\"fa-solid fa-share fa-xl\" style=\"color: #ece1ff;\"></i></button>\r\n\t\t\t\t\t<button class=\"report-post\"><i class=\"fa-solid fa-flag fa-xl\" style=\"color: #FFE482;\"></i></button>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 35 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"

			}
		

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t<span class=\"date text-white fw-bold\">");
            Write(
#nullable restore
#line 38 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                         GetTimeAgo(Model.PostDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n\r\n\t</div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
            
	public string GetTimeAgo(DateTime date)
	{
		TimeSpan elapsedTime = DateTime.Now - date;

		if (elapsedTime < TimeSpan.FromHours(1))
			return elapsedTime.Minutes + "m" + " Ago";
		if (elapsedTime < TimeSpan.FromHours(24))
			return elapsedTime.Hours + "h" + " Ago";
		if (elapsedTime < TimeSpan.FromDays(7))
			return elapsedTime.Days + "d" + " Ago";
		if (elapsedTime < TimeSpan.FromDays(28))
			return elapsedTime.Days / 7 + "w" + " Ago";
		if (elapsedTime < TimeSpan.FromDays(356))
			return elapsedTime.Days / 28 + "mo" + " Ago";

		return elapsedTime.Days / 365 + "y" + " Ago";


	}

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostDetailModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
