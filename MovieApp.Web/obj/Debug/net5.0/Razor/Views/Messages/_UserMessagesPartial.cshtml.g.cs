#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76d0cbfcc7578c39077cde8acf177b4c70abc7320a4d2fb9157f1a789b9776d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages__UserMessagesPartial), @"mvc.1.0.view", @"/Views/Messages/_UserMessagesPartial.cshtml")]
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
using MemoMate.Web.Controllers;

#nullable disable
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.GeneralHelpers;

#nullable disable
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Interfaces;

#nullable disable
#nullable restore
#line 4 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models;

#nullable disable
#nullable restore
#line 5 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models.Posts;

#nullable disable
#nullable restore
#line 6 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models.Search;

#nullable disable
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Web.Models.Users;

#nullable disable
#nullable restore
#line 8 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\_ViewImports.cshtml"
using MemoMate.Data;

#nullable disable
#nullable restore
#line 1 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
 using MemoMate.Web.Models.Messages

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"76d0cbfcc7578c39077cde8acf177b4c70abc7320a4d2fb9157f1a789b9776d3", @"/Views/Messages/_UserMessagesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"551a3915c97d0c6e79dc14e84bc521a5b2e0c70180d8746e3ad102c5321891b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Messages__UserMessagesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SelectedUserMessages>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
 foreach (var message in Model.Messages)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t<div");
            BeginWriteAttribute("class", " class=\"", 120, "\"", 180, 2);
            WriteAttributeValue("", 128, "message-in", 128, 10, true);
            WriteAttributeValue(" ", 138, 
#nullable restore
#line 7 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
                         GetMessageOwnerClass(message.UserFromID)

#line default
#line hidden
#nullable disable
            , 139, 41, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t<div class=\"message-photo\">\r\n\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 222, "\"", 287, 2);
            WriteAttributeValue("", 228, "/img/user/profile/", 228, 18, true);
            WriteAttributeValue("", 246, 
#nullable restore
#line 9 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
                                GetMessageOwnerPhoto(message.UserFromID)

#line default
#line hidden
#nullable disable
            , 246, 41, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\t\t</div>\r\n\t\t<div class=\"message-content\">\r\n\t\t\t<p>");
            Write(
#nullable restore
#line 12 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
       message.Content

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\t\t</div>\t\t\r\n\t\t<div class=\"message-details\">\r\n\t\t\t<p>");
            Write(
#nullable restore
#line 15 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
       TimeHelpers.GetOnlyTime(message.SentDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 18 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\_UserMessagesPartial.cshtml"
  
	string GetMessageOwnerClass(int id)
	{
		if (id == Model.User.ID)
			return "op";
		return "us";
	}
	string GetMessageOwnerPhoto(int id)
	{
		if (id == Model.User.ID)
			return Model.User.Photo;
		return Model.LoggedUser.Photo;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SelectedUserMessages> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591