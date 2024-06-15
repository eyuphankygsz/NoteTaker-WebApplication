#pragma checksum "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71794adb1c4c6cd37933294e3c7d659c2f6a30607be7cab1d9cc4c2504fc6604"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"71794adb1c4c6cd37933294e3c7d659c2f6a30607be7cab1d9cc4c2504fc6604", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"df36c760b636adba1a95ca388a2562bed9818eb52a1c53ef12e60a1a4dbf5f10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserLoginViewModel>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71794adb1c4c6cd37933294e3c7d659c2f6a30607be7cab1d9cc4c2504fc66044317", async() => {
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
#line 6 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Home\Index.cshtml"
  
	Layout = "_MainLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<div class=""main"">
	<div class=""d-flex container  justify-content-center"">
		<div class=""card text-white welcome bg-transparent border-0 ps-5"">
			<div class=""card-body ps-5"">
				<h1 class=""card-title text-left m-0"" style=""font-size: 1.4rem"">Welcome to</h1>
				<h1 class=""card-title text-left"" style=""font-size: 4.2rem"">MemoMate</h1>
				<p class=""card-text text-left""><strong>MemoMate</strong> is a unique platform where users can <strong>share, read, and rate short notes</strong> on a variety of topics. Whether you're passionate about <em>science</em>, <em>comedy</em>, or anything in between, <strong>MemoMate</strong> is the perfect place to share your thoughts and insights. Here's how it works:</p>

				<!--nav-->
				<div class=""card text-center step-container"">
					<div class=""card-header step-container-color"">
						<ul class=""nav nav-tabs steps"" id=""myTab"" role=""tablist"">
							<li class=""nav-item"" role=""presentation"">
								<button class=""nav-link active text-light"" id=""home-tab"" data-b");
            WriteLiteral(@"s-toggle=""tab"" data-bs-target=""#step1"" type=""button"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Step1</button>
							</li>
							<li class=""nav-item"" role=""presentation"">
								<button class=""nav-link text-light"" id=""profile-tab"" data-bs-toggle=""tab"" data-bs-target=""#step2"" type=""button"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Step2</button>
							</li>
							<li class=""nav-item"" role=""presentation"">
								<button class=""nav-link text-light"" id=""contact-tab"" data-bs-toggle=""tab"" data-bs-target=""#step3"" type=""button"" role=""tab"" aria-controls=""contact"" aria-selected=""false"">Step3</button>
							</li>
						</ul>
						<div class=""tab-content"" id=""myTabContent"">
							<div class=""tab-pane fade show active"" id=""step1"" role=""tabpanel"" aria-labelledby=""step1-tab"">
								<div class=""LoginShow text-light "">
									<div class=""card-header"">Account</div>
									<img class=""card-img-top cardImage ci1"" src=""/img/home/icons/sign-up.png"" alt=""Card image cap"">
							");
            WriteLiteral(@"		<div class=""card-body"">
										<h5 class=""card-title"">Have An Account?</h5>
										<p class=""card-text"">If you already have an account, sign in to start sharing your notes! If you don't have one yet, sign up now and start sharing your notes with the world!</p>
									</div>
								</div>

								<div class=""card-body"">
									<h5 class=""card-title text-white"">Don't Have An Account?</h5>
									<a");
            BeginWriteAttribute("href", " href=\"", 2605, "\"", 2644, 1);
            WriteAttributeValue("", 2612, 
#nullable restore
#line 44 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Home\Index.cshtml"
                   Url.Action("Index", "Register")

#line default
#line hidden
#nullable disable
            , 2612, 32, false);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Sign Up</a>
								</div>
							</div>
							<div class=""tab-pane fade"" id=""step2"" role=""tabpanel"" aria-labelledby=""step2-tab"">
								<div class=""CreateNoteShow d-grid gap-3 text-light"">
									<div class=""card-header"">Create Note</div>
									<img class=""card-img-top cardImage"" src=""/img/home/icons/notes.png"" alt=""Card image cap"">
									<div class=""card-body"">
										<h5 class=""card-title"">Create a Note</h5>
										<p class=""card-text"">Write a short note about science, comedy, or any topic you want and share it with the world! It's time to share something new you've learned or want to share!</p>
									</div>
								</div>
							</div>
							<div class=""tab-pane fade"" id=""step3"" role=""tabpanel"" aria-labelledby=""step3-tab"">
								<div class=""HighNoteShow text-light"">

									<div class=""card-header"">Rate</div>
									<img class=""card-img-top cardImage ci3"" src=""/img/home/icons/rate.png"" alt=""Card image cap"">
									<div class=""card-body");
            WriteLiteral(@""">
										<h5 class=""card-title"">Rate the Notes</h5>
										<p class=""card-text"">Read and rate notes from randomly selected online users! Contribute to the process of sharing knowledge by selecting the best notes and helping other users discover them!</p>
									</div>

								</div>
							</div>
						</div>
					</div>
				</div>
				<!--eonav-->
			</div>
		</div>
		<form class=""login-section"" asp-action=""Index"" method=""post"">
			<div class=""container"">
				<div class=""row d-flex justify-content-center align-items-center"">
					<div class=""login-extension"">
						<div class=""card shadow-2-strong"" style=""border-radius: 1rem;"">
							<div class=""card-body p-4 text-center"">
								<h3 class=""mb-3"">Sign in</h3>

								<div data-mdb-input-init class=""form-outline mb-1"">
									<input type=""text"" id=""usernameField"" asp-for=""Username"" name=""Username"" class=""form-control form-control-sm"" />
									<label class=""form-label"" for=""usernameField"">Username</label>
								</div");
            WriteLiteral(@">

								<div data-mdb-input-init class=""form-outline mb-1"">
									<input type=""password"" id=""passwordField"" asp-for=""Password"" name=""Password"" class=""form-control form-control-sm"" />
									<label class=""form-label"" for=""passwordField"">Password</label>
								</div>

								<button data-mdb-button-init data-mdb-ripple-init class=""btn btn-primary btn-lg btn-block logbtn"" type=""submit"">Login to your Account</button>
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
					<button type=""but");
            WriteLiteral("ton\" class=\"btn btn-primary\">Save changes</button>\r\n\t\t\t\t\t<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserLoginViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591