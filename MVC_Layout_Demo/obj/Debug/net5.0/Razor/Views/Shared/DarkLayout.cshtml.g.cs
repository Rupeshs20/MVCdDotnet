#pragma checksum "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2efc33eb5049ec8e5d5e890b7604c8e608429cdf886180d16d8c5bd6fa9b8f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DarkLayout), @"mvc.1.0.view", @"/Views/Shared/DarkLayout.cshtml")]
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
#line 1 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\_ViewImports.cshtml"
using MVC_Layout_Demo

#nullable disable
    ;
#nullable restore
#line 2 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\_ViewImports.cshtml"
using MVC_Layout_Demo.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2efc33eb5049ec8e5d5e890b7604c8e608429cdf886180d16d8c5bd6fa9b8f0f", @"/Views/Shared/DarkLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"34926a2469cf8639851066166cc481fdddd57fc4620cb506b0f27639534bfe08", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_DarkLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:burlywood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n \r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2efc33eb5049ec8e5d5e890b7604c8e608429cdf886180d16d8c5bd6fa9b8f0f4635", async() => {
                WriteLiteral("\r\n<meta name=\"viewport\" content=\"width=device-width\" />\r\n<title>");
                Write(
#nullable restore
#line 6 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
        ViewBag.Title

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2efc33eb5049ec8e5d5e890b7604c8e608429cdf886180d16d8c5bd6fa9b8f0f5954", async() => {
                WriteLiteral("\r\n \r\n    <!-- Header -->\r\n<header>\r\n<h1 style=\"text-align:center; color:bisque\">My Dark Layout Page</h1>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2efc33eb5049ec8e5d5e890b7604c8e608429cdf886180d16d8c5bd6fa9b8f0f6350", async() => {
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
                WriteLiteral("\r\n</header>\r\n<!-- End of Header -->\r\n<!-- Left Sidebar -->\r\n<nav>\r\n        HTML helper method ActionLink\r\n<h3>Navigation</h3>\r\n                          title , action, controller\r\n        ");
                Write(
#nullable restore
#line 21 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
         Html.ActionLink("About", "About","Home")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(";<br />\r\n        ");
                Write(
#nullable restore
#line 22 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
         Html.ActionLink("Contact", "Contact","Home")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(";<br />\r\n        ");
                Write(
#nullable restore
#line 23 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
         Html.ActionLink("Enquiry", "Enquiry","Home")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(";<br />\r\n</nav>\r\n<!-- End of Left Sidebar -->\r\n<!-- Content Body -->\r\n<div class=\"content\">\r\n        ");
                Write(
#nullable restore
#line 28 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
         RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n</div>\r\n \r\n    <div style=\"background-color:rebeccapurple; color:antiquewhite; font-weight:bold\">\r\n        ");
                Write(
#nullable restore
#line 32 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
         RenderSection("Note", false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n</div>\r\n<!-- End of Content Body -->\r\n<!-- Footer -->\r\n<footer>\r\n<h4>I am Footer@copyRights http://www.Synergetics.com</h4>\r\n<div style=\"background-color:red; color:aliceblue\">");
                Write(
#nullable restore
#line 38 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
                                                    RenderSection("Footer", false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</div>\r\n</footer>\r\n    ");
                Write(
#nullable restore
#line 40 "D:\DotNet\DotnetMVC\MVC_Layout_Demo\Views\Shared\DarkLayout.cshtml"
     RenderSection("Scripts", required: false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
<!-- Style -->
<style>
        header {
            height: 100px;
            width: 100%;
            background-color: red;
        }
 
        nav {
            float: left;
            width: 200px;
            height: 250px;
            background-color: darkgoldenrod;
        }
 
        .content {
            background-color: aliceblue;
            padding: 20px;
        }
 
        footer {
            background-color: green;
            width: 100%;
            height: 50px;
            float: right;
            text-align: center;
        }
</style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\nhas context menu");
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
