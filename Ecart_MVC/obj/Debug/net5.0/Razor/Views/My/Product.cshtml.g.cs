#pragma checksum "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67cbd8a84020ec0ff0af5b2779dc8d71bf42a30c8bb141952be0d3a83578be1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_Product), @"mvc.1.0.view", @"/Views/My/Product.cshtml")]
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
#line 1 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\_ViewImports.cshtml"
using Ecart_MVC

#nullable disable
    ;
#nullable restore
#line 2 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\_ViewImports.cshtml"
using Ecart_MVC.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"67cbd8a84020ec0ff0af5b2779dc8d71bf42a30c8bb141952be0d3a83578be1f", @"/Views/My/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4b4f42c730552deeb852ad059257fc4a670889f6d0a645986448be830bc95215", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_My_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ecart_MVC.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Product List</h2>

<table>
    <thead>
        <tr>
            <th>Product ID</th>
            <th>Product Name</th>
            <th>Description</th>
            <th>Price</th>
            <th>Type</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 19 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml"
                     product.ProdId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 20 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml"
                     product.ProdName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 21 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml"
                     product.ProdDesc

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 22 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml"
                     product.ProdPrice

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 23 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml"
                     product.ProdType

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\DotNet\DotnetMVC\Ecart_MVC\Views\My\Product.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ecart_MVC.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
