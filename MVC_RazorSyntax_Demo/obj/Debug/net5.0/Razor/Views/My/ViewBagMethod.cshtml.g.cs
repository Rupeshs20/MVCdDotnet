#pragma checksum "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "240d1e6c0d6c33af35407bc60f6dae9211aeeb35f70021ec4124ff59838a7be6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_ViewBagMethod), @"mvc.1.0.view", @"/Views/My/ViewBagMethod.cshtml")]
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
#line 1 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\_ViewImports.cshtml"
using MVC_RazorSyntax_Demo

#nullable disable
    ;
#nullable restore
#line 2 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\_ViewImports.cshtml"
using MVC_RazorSyntax_Demo.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"240d1e6c0d6c33af35407bc60f6dae9211aeeb35f70021ec4124ff59838a7be6", @"/Views/My/ViewBagMethod.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"61df97dc416d8cb0bf9f9bfa5dcd3e48510e17c502835f35f150d305bb8e3ecd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_My_ViewBagMethod : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>ViewBag Method from MyController</h2>\r\n\r\n<p>Developer Name: ");
            Write(
#nullable restore
#line 5 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
                    ViewBag.developername

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n<p>Today is: ");
            Write(
#nullable restore
#line 6 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
              ViewBag.today

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\r\n<h3>Fruits List:</h3>\r\n");
#nullable restore
#line 9 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
  
    var fruitlist = ViewBag.fruitlist as List<string>;
    

#line default
#line hidden
#nullable disable

#nullable restore
#line 11 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
     foreach (string fruit in fruitlist)
    { 

#line default
#line hidden
#nullable disable

            WriteLiteral("        <li>\r\n        ");
            Write(
#nullable restore
#line 14 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
         fruit

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 16 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h3>Students List:</h3>\r\n");
#nullable restore
#line 20 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
  
    var studentlist = ViewBag.Studentlist as List<Student>;
    

#line default
#line hidden
#nullable disable

#nullable restore
#line 22 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
     foreach (var student in studentlist)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <p>Id: ");
            Write(
#nullable restore
#line 24 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
                student.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(", &nbsp Name: ");
            Write(
#nullable restore
#line 24 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
                                         student.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(",  &nbsp Marks: ");
            Write(
#nullable restore
#line 24 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
                                                                      student.Marks

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "D:\DotNet\DotnetMVC\MVC_RazorSyntax_Demo\Views\My\ViewBagMethod.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
