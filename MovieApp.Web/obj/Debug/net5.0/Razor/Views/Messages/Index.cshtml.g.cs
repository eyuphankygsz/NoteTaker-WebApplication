#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b63b98684b2582a0f1ef82d613052137b024c4e89e706fc74fea4678fc5910b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
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
#line 1 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
 using MemoMate.Web.Models.Messages

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b63b98684b2582a0f1ef82d613052137b024c4e89e706fc74fea4678fc5910b9", @"/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"551a3915c97d0c6e79dc14e84bc521a5b2e0c70180d8746e3ad102c5321891b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserMessagesModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/posts.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/details.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b63b98684b2582a0f1ef82d613052137b024c4e89e706fc74fea4678fc5910b95822", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b63b98684b2582a0f1ef82d613052137b024c4e89e706fc74fea4678fc5910b97022", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
#line 9 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
  
	ViewData["Title"] = Model.LoggedUserEntity.Username + "'s Messages";
	Layout = "_LoggedLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            DefineSection("SideExtension", async() => {
                WriteLiteral("\r\n\t");
                Write(
#nullable restore
#line 15 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
  await Html.PartialAsync("_sidebar", await SidebarService.GetSidebarModelAsync(Model.LoggedUserEntity))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div id=\"messages-page\">\r\n\t<div class=\"custom-container m-auto\">\r\n\t\t<div class=\"card-header\">\r\n\t\t\t<h5>");
            Write(
#nullable restore
#line 20 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
        Model.LoggedUserEntity.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\'s Likes</h5>\r\n\t\t</div>\r\n\t\t<div class=\"card-body\">\r\n\t\t\t<div class=\"list-group\">\r\n");
#nullable restore
#line 24 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
     foreach (var post in Model.Messages)
				{
					

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 26 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
      await Html.PartialAsync("_post", post)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 26 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
                                            
				}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
  
	if (MessageHelpers.PostBack)
	{
		

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 36 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
   await Html.PartialAsync("_message", MessageHelpers.TryGetMessageModel())

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 36 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
                                                                           
	}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            DefineSection("BottomExtension", async() => {
                WriteLiteral("\r\n\t");
                Write(
#nullable restore
#line 41 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
  await Html.PartialAsync("_bottombar", Model.LoggedUserEntity)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n\t<script src=\"/js/friendship.js\"></script>\r\n\t<script src=\"/js/Posts/posts.js\"></script>\r\n\t<script src=\"/js/Posts/posts-likes.js\"></script>\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
        ISidebarService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Messages\Index.cshtml"
                        SidebarService

#line default
#line hidden
#nullable disable
         { get; private set; }
         = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserMessagesModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
