#pragma checksum "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "906b2ce9d5d22012ade220b9e71cf3ff72b5c1833eb49f0a00203a1bef758e9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"906b2ce9d5d22012ade220b9e71cf3ff72b5c1833eb49f0a00203a1bef758e9f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"551a3915c97d0c6e79dc14e84bc521a5b2e0c70180d8746e3ad102c5321891b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserLoginModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "906b2ce9d5d22012ade220b9e71cf3ff72b5c1833eb49f0a00203a1bef758e9f5242", async() => {
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
#line 6 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Home\Index.cshtml"
  
	Layout = "_MainLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<div class=""main"">
	<div class=""d-flex main-content"">
		<div class=""card text-white welcome bg-transparent border-0 ps-5 w-50"">
			<div class=""card-body ps-5"">
				<h1 class=""card-title text-left m-0"" id=""welcome-text"">Welcome to</h1>
				<h1 class=""card-title text-left"" id=""name-text"">MemoMate</h1>

				<div class=""step-container"">

					<div class=""card choice expand text-white custom-card"" id=""card1"">
						<div class=combiner>
							<div class=""card-step"">1</div>
							<div class=""card-body"">

								<div class=""custom-card-header"">Account</div>
								<img class=""card-img-top cardImage d-block m-auto"" src=""/img/home/icons/sign-up.png"" alt=""Card image cap"">
								<div class=""m-auto h-100 card-info"">
									<h5 class=""card-title text-left"">Have An Account?</h5>
									<p class=""card-text text-left"">If you already have an account, sign in to start sharing your notes! If you don't have one yet, sign up now and start sharing your notes with the world!</p>
								</div>
							</");
            WriteLiteral(@"div>
						</div>
					</div>
					<div class=""card choice small text-white custom-card"" id=""card2"">
						<div class=combiner>
							<div class=""card-step"">2</div>
							<div class=""card-body"">

								<div class=""custom-card-header"">Create Note</div>
								<img class=""card-img-top cardImage d-block m-auto"" src=""/img/home/icons/notes.png"" alt=""Card image cap"">
								<div class=""m-auto h-100 card-info"">
									<h5 class=""card-title text-left"">What do you think?</h5>
									<p class=""card-text text-left"">Write a short note about science, comedy, or any topic you want and share it with the world! It's time to share something new you've learned or want to share!</p>
								</div>
							</div>
						</div>
					</div>


					<div class=""card choice small text-white custom-card"" id=""card3"">
						<div class=combiner>
							<div class=""card-step"">3</div>
							<div class=""card-body"">

								<div class=""custom-card-header"">Rating</div>
								<img class=""card-img-top cardIm");
            WriteLiteral(@"age d-block m-auto"" src=""/img/home/icons/rate.png"" alt=""Card image cap"">
								<div class=""m-auto h-100 card-info"">
									<h5 class=""card-title text-left"">Rate the Notes</h5>
									<p class=""card-text text-left"">Read and rate notes from randomly selected online users! Contribute to the process of sharing knowledge by selecting the best notes and helping other users discover them!</p>
								</div>

							</div>
						</div>
					</div>


				</div>
			</div>
		</div>
		<form class=""login-section w-50"" method=""post"">
			<div class=""container"">
				<div class=""row d-flex justify-content-center align-items-center"">
					<div class=""login-extension"">
						<div class=""card shadow-2-strong card-background"" style=""border-radius: 1rem;"">
							<div class=""card-body p-4"">
								<h3 class=""mb-3 text-white text-center"">Sign in</h3>

								<div data-mdb-input-init class=""form-outline mb-3"">
									<label class=""form-label text-white fw-bold"" for=""usernameField"">Username</label>
	");
            WriteLiteral(@"								<input type=""text"" id=""usernameField"" asp-for=""Username"" name=""Username"" class=""form-control form-control-sm"" />
								</div>

								<div data-mdb-input-init class=""form-outline mb-1"">
									<label class=""form-label text-white fw-bold"" for=""passwordField"">Password</label>
									<input type=""password"" id=""passwordField"" asp-for=""Password"" name=""Password"" class=""form-control form-control-sm"" />
								</div>

								<div class=""text-center w-100 mt-3"">
									<button data-mdb-button-init data-mdb-ripple-init class=""btn btn-primary btn-lg btn-block logbtn w-100 mb-3"" type=""submit"">Sign In</button>
									<a");
            BeginWriteAttribute("href", " href=\"", 3847, "\"", 3885, 1);
            WriteAttributeValue("", 3854, 
#nullable restore
#line 88 "C:\Users\AmiralSincap\Documents\GitHub\NoteTaker-WebApplication\MovieApp.Web\Views\Home\Index.cshtml"
                   Url.Action("Index","Register")

#line default
#line hidden
#nullable disable
            , 3854, 31, false);
            EndWriteAttribute();
            WriteLiteral(@"><button class=""btn btn-primary btn-lg btn-block logbtn w-100"" type=""button"">Sign Up</button></a>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</form>
	</div>

	<div class=""modal"" tabindex=""-1"" role=""dialog"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"">Modal title</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
					<p>Modal body text goes here.</p>
				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-primary"">Save changes</button>
					<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
				</div>
			</div>
		</div>
	</div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script src=\"/js/homeindex.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserLoginModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
