#pragma checksum "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_MainLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1031e5e8ace38a083782ac30b7c91e8b0dd27a8f5635102c9aa650d3f588b1f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MainLayout), @"mvc.1.0.view", @"/Views/Shared/_MainLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1031e5e8ace38a083782ac30b7c91e8b0dd27a8f5635102c9aa650d3f588b1f6", @"/Views/Shared/_MainLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"df36c760b636adba1a95ca388a2562bed9818eb52a1c53ef12e60a1a4dbf5f10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__MainLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1031e5e8ace38a083782ac30b7c91e8b0dd27a8f5635102c9aa650d3f588b1f63709", async() => {
                WriteLiteral(@"
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
	<title>Memo Mate</title>
	<link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
	<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
	<link href=""https://fonts.googleapis.com/css2?family=Kanit:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"" rel=""stylesheet"" />
	<link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
	<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
	<link href=""https://fonts.googleapis.com/css2?family=Oxanium:wght@200..800&display=swap"" rel=""stylesheet"" />
	<link href=""/css/navbar.css"" rel=""stylesheet"" />
	");
                Write(
#nullable restore
#line 14 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_MainLayout.cshtml"
  RenderSection("Styles", required: false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n\t<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH\" crossorigin=\"anonymous\">\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1031e5e8ace38a083782ac30b7c91e8b0dd27a8f5635102c9aa650d3f588b1f66059", async() => {
                WriteLiteral("\r\n\t\t");
                Write(
#nullable restore
#line 20 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_MainLayout.cshtml"
   await Html.PartialAsync("_navbar")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(";\r\n\t<div class=\"main-content\">\r\n\t\t<div class=\"afterlayout\">\r\n\t\t\t");
                Write(
#nullable restore
#line 23 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_MainLayout.cshtml"
    RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
		</div>
	</div>

	<script src=""https://kit.fontawesome.com/46dac6df79.js"" crossorigin=""anonymous""></script>
	<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"" crossorigin=""anonymous""></script>
	");
                Write(
#nullable restore
#line 29 "C:\Users\AmiralSincap\Documents\MEGA\source\repos\MovieAppTutorial\MovieApp.Web\Views\Shared\_MainLayout.cshtml"
  RenderSection("Scripts", required: false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(";\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
