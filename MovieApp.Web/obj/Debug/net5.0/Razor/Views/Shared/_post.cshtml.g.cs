#pragma checksum "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0525c25edee93861357140c0a394366d584659f691d661cc44912bd74923541f"
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
#line 1 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Data;

#nullable disable
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Controllers;

#nullable disable
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0525c25edee93861357140c0a394366d584659f691d661cc44912bd74923541f", @"/Views/Shared/_post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"df36c760b636adba1a95ca388a2562bed9818eb52a1c53ef12e60a1a4dbf5f10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Note>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card text-center mb-3\">\r\n\t<div class=\"card-header\">\r\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 84, "\"", 152, 1);
            WriteAttributeValue("", 91, 
#nullable restore
#line 5 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml"
            Url.Action("Details", "User", new { id = Model.Creator.ID })

#line default
#line hidden
#nullable disable
            , 91, 61, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 163, "\"", 207, 2);
            WriteAttributeValue("", 169, "/img/user/profile/", 169, 18, true);
            WriteAttributeValue("", 187, 
#nullable restore
#line 6 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml"
                                Model.Creator.Photo

#line default
#line hidden
#nullable disable
            , 187, 20, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\t\t\t");
            Write(
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml"
    Model.Creator.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t</a>\r\n\t</div>\r\n\t<div class=\"card-body\">\r\n\t\t<h5 class=\"card-title\">");
            Write(
#nullable restore
#line 11 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml"
                          Model.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n\t\t<p class=\"card-text\">");
            Write(
#nullable restore
#line 12 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml"
                        Model.Content

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\t</div>\r\n\t<div class=\"card-footer text-body-secondary\">\r\n\t\t");
            Write(
#nullable restore
#line 15 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml"
   GetTimeAgo(Model.Date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_post.cshtml"
            
	public string GetTimeAgo(DateTime date)
	{
		TimeSpan elapsedTime = DateTime.Now - date;

		if (elapsedTime < TimeSpan.FromHours(1))
			return elapsedTime.Minutes + " Minute" + (elapsedTime.Minutes == 1 ? "" : "(s)") + " Ago";
		if (elapsedTime < TimeSpan.FromHours(24))
			return elapsedTime.Hours + " Hour" + (elapsedTime.Hours == 1 ? "" : "(s)") + " Ago";
		if (elapsedTime < TimeSpan.FromDays(7))
			return elapsedTime.Days + " Day" + (elapsedTime.Days == 1 ? "" : "(s)") + " Ago";
		if (elapsedTime < TimeSpan.FromDays(28))
			return elapsedTime.Days / 7 + " Week" + (elapsedTime.Days / 7 == 1 ? "" : "(s)") + " Ago";
		if (elapsedTime < TimeSpan.FromDays(356))
			return elapsedTime.Days / 28 + " Month" + (elapsedTime.Days / 28 == 1 ? "" : "(s)") + " Ago";

		return elapsedTime.Days / 365 + " Year" + (elapsedTime.Days / 365 == 1 ? "" : "(s)") + " Ago";


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Note> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
