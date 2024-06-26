#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7b11989c4e97b354f7270cd92a201e0dd5997ee37e7b0792b09c32346330bf5e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7b11989c4e97b354f7270cd92a201e0dd5997ee37e7b0792b09c32346330bf5e", @"/Views/Shared/_post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b31008db680e9423da7e6b4d478e42b926181cc1143b5eadf66e1636d591bfbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostDetailModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card text-center mb-3\">\r\n\t<div class=\"card-header\">\r\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 95, "\"", 161, 1);
            WriteAttributeValue("", 102, 
#nullable restore
#line 5 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
            Url.Action("Details", "User", new { id = Model.Username })

#line default
#line hidden
#nullable disable
            , 102, 59, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 172, "\"", 212, 2);
            WriteAttributeValue("", 178, "/img/user/profile/", 178, 18, true);
            WriteAttributeValue("", 196, 
#nullable restore
#line 6 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                                Model.UserPhoto

#line default
#line hidden
#nullable disable
            , 196, 16, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\t\t\t");
            Write(
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
    Model.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t</a>\r\n\t</div>\r\n\t<div class=\"card-body\">\r\n\t\t<h5 class=\"card-title\">");
            Write(
#nullable restore
#line 11 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                          Model.NoteTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n\t\t<p class=\"card-text\">");
            Write(
#nullable restore
#line 12 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                        Model.NoteContent

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\t</div>\r\n\t<div class=\"card-footer text-body-secondary\">\r\n\t\t<span class=\"rate\">★ ");
            Write(
#nullable restore
#line 15 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                        Model.PostRate.ToString("0.00")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n\t\t<span class=\"date\">");
            Write(
#nullable restore
#line 16 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
                      GetTimeAgo(Model.PostDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n\r\n\t</div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Shared\_post.cshtml"
            
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostDetailModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
