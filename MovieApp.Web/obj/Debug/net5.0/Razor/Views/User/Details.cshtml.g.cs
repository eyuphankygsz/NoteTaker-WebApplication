#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "116aa4741f8ed1a58baddb4e7b5a46f177878642c22ad79439c8e9619439d51b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"116aa4741f8ed1a58baddb4e7b5a46f177878642c22ad79439c8e9619439d51b", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b31008db680e9423da7e6b4d478e42b926181cc1143b5eadf66e1636d591bfbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProfileViewModel>
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "116aa4741f8ed1a58baddb4e7b5a46f177878642c22ad79439c8e9619439d51b5052", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "116aa4741f8ed1a58baddb4e7b5a46f177878642c22ad79439c8e9619439d51b6254", async() => {
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
#line 8 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
  
	ViewData["Title"] = Model.Username + "'s Profile";
	Layout = "_LoggedLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            DefineSection("SideExtension", async() => {
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 14 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
     await Html.PartialAsync("_sidebar", await SidebarService.GetSidebarModelAsync(Model.LoggedUserEntity))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"container mt-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 570, "\"", 606, 2);
            WriteAttributeValue("", 576, "/img/user/profile/", 576, 18, true);
            WriteAttributeValue("", 594, 
#nullable restore
#line 21 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                             Model.Photo

#line default
#line hidden
#nullable disable
            , 594, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top rounded-circle mt-4\" id=\"profile-photo\" alt=\"User Photo\">\r\n                <div class=\"card-body text-center\">\r\n                    <h4 class=\"card-title\">");
            Write(
#nullable restore
#line 23 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                            Model.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">");
            Write(
#nullable restore
#line 24 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                          Model.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <div class=""col-md-8"">
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <h5>User Details</h5>
                </div>
                <div class=""card-body"">
                    <p><strong>Email:</strong> ");
            Write(
#nullable restore
#line 34 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                Model.Mail

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <p><strong>Full Name:</strong> ");
            Write(
#nullable restore
#line 35 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                    Model.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <p><strong>Creation Date:</strong> ");
            Write(
#nullable restore
#line 36 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                        Model.CreationDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <!-- Add other user details as needed -->\r\n                </div>\r\n            </div>\r\n            <div class=\"card custom-bottom\">\r\n                <div class=\"card-header\">\r\n                    <h5>");
            Write(
#nullable restore
#line 42 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                         Model.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\'s Posts</h5>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"list-group\">\r\n");
#nullable restore
#line 46 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                         foreach (var post in Model.Posts)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1892, 2);
            WriteAttributeValue("", 1868, "/Posts/Post/", 1868, 12, true);
            WriteAttributeValue("", 1880, 
#nullable restore
#line 48 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                  post.PostID

#line default
#line hidden
#nullable disable
            , 1880, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action flex-column align-items-start\">\r\n                                <div class=\"d-flex w-100 justify-content-between\">\r\n                                    <h5 class=\"mb-1 w-75\">");
            Write(
#nullable restore
#line 50 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                           post.NoteTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n                                    <small>");
            Write(
#nullable restore
#line 51 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                            post.PostDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</small>\r\n                                </div>\r\n                                <p class=\"mb-1\">");
            Write(
#nullable restore
#line 53 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                 post.NoteContent

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                                <small>Rating: ");
            Write(
#nullable restore
#line 54 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                post.PostRate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</small>\r\n                            </a>\r\n");
#nullable restore
#line 56 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
  
    if (MessageHelpers.PostBack)
    {
        

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 67 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
         await Html.PartialAsync("_message", MessageHelpers.TryGetMessageModel())

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 67 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
                                                                                 
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            DefineSection("BottomExtension", async() => {
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 72 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
     await Html.PartialAsync("_bottombar", Model.LoggedUserEntity)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n    <script src=\"/js/Posts/posts.js\"></script>\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
        ISidebarService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\User\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProfileViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
