#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a158fe9e7875a76595db168c3c6ba79e72608acc3871faa8e5fb47c6971d7c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Create), @"mvc.1.0.view", @"/Views/Posts/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8a158fe9e7875a76595db168c3c6ba79e72608acc3871faa8e5fb47c6971d7c9", @"/Views/Posts/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b31008db680e9423da7e6b4d478e42b926181cc1143b5eadf66e1636d591bfbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Posts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/posts.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
  
	ViewData["title"] = "Create Post";

#line default
#line hidden
#nullable disable

            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a158fe9e7875a76595db168c3c6ba79e72608acc3871faa8e5fb47c6971d7c94880", async() => {
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
                WriteLiteral("\r\n");
            }
            );
#nullable restore
#line 9 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
  
	Layout = "_LoggedLayout";

#line default
#line hidden
#nullable disable

            DefineSection("SideExtension", async() => {
                WriteLiteral("\r\n\t");
                Write(
#nullable restore
#line 13 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
  await Html.PartialAsync("_sidebar", await SidebarService.GetSidebarModelAsync(Model.LoggedUserEntity))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"posts-main\">\r\n\r\n\t");
            Write(
#nullable restore
#line 18 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
  await Html.PartialAsync("_welcome", Model.LoggedUserEntity)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"


	<div id=""create-container"">
		<div id=""create-part"">
			<div class=""posts-content"">
				<div class=""card text-center mb-3"">
					<form asp-action=""Create"" method=""post"">
						<div class=""card-header"">
							<input id=""titleInput"" type=""text"" name=""Title"" class=""form-control text-light fw-bolder"" placeholder=""Note Title"" required />
							<p id=""titleMax"">0/30</p>
						</div>
						<div class=""card-body"">
							<textarea id=""contentInput"" name=""Content"" class=""form-control text-light fw-bold"" placeholder=""Note Content"" required></textarea>
							<p id=""contentMax"">0/250</p>
						</div>
						<div class=""card-footer text-body-secondary"">
							<div class=""theme_text""><p>");
            Write(
#nullable restore
#line 35 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
                                   Model.ThemeName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p></div>
							<span class=""d-flex"" id=""createButton-span"" tabindex=""0"">
								<button class=""btn btn-danger"" type=""submit"" disabled>Create Post</button>
							</span>
						</div>
					</form>


				</div>
			</div>
		</div>
		<div id=""will-be-added"">
			<h1>Will be added soon.</h1>
		</div>
	</div>
</div>
");
#nullable restore
#line 51 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
  
	if (MessageHelpers.PostBack)
	{
		

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 54 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
   await Html.PartialAsync("_message", MessageHelpers.TryGetMessageModel())

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 54 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
                                                                           
	}

#line default
#line hidden
#nullable disable

            DefineSection("BottomExtension", async() => {
                WriteLiteral("\r\n\t");
                Write(
#nullable restore
#line 58 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
  await Html.PartialAsync("_bottombar", Model.LoggedUserEntity)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<script>\r\n\tdocument.title = \"");
            Write(
#nullable restore
#line 61 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
                    ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\";\r\n\r\n\tconst popoverTriggerList = document.querySelectorAll(\'[data-bs-toggle=\"popover\"]\')\r\n\tconst popoverList = [...popoverTriggerList].map(popoverTriggerEl => new bootstrap.Popover(popoverTriggerEl))\r\n</script>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script src=\"/js/Posts/posts.js\"></script>\r\n\t<script src=\"/js/Posts/posts-create.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
        ISidebarService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Posts\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
