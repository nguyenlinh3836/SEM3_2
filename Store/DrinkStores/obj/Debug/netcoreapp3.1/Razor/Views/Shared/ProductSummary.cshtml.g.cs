#pragma checksum "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f38e2d48dbb0fc461d47d1d970d68db1f67c7ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\_ViewImports.cshtml"
using DrinkStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\_ViewImports.cshtml"
using DrinkStores.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\_ViewImports.cshtml"
using DrinkStores.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f38e2d48dbb0fc461d47d1d970d68db1f67c7ac", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7e059381c8f72f0ddef7b84bcea8736930d20b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"card card-outline-primary m-1 p-1\">\n    <div class=\"bg-faded p-1 \">\n        <h4");
            BeginWriteAttribute("style", " style=\"", 196, "\"", 204, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\Shared\ProductSummary.cshtml"
                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <img");
            BeginWriteAttribute("src", " src=\"", 235, "\"", 251, 1);
#nullable restore
#line 12 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\Shared\ProductSummary.cshtml"
WriteAttributeValue("", 241, Model.Img, 241, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        <span class=\"badge badge-pill badge-primary\" style=\"float:right;font-size:20px\">\n            <small>");
#nullable restore
#line 14 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\Shared\ProductSummary.cshtml"
              Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n          \n        </span>\n        <span class=\"badge badge-pill badge-primary bg-danger\" style=\"float:right;font-size:20px\">\n            <small>Sales : ");
#nullable restore
#line 18 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\Shared\ProductSummary.cshtml"
                      Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</small>\n\n        </span>\n    </div>\n    <div class=\"card-text p-1\">\n        ");
#nullable restore
#line 23 "C:\Users\LEGION\Downloads\DrinkStores\DrinkStores\Views\Shared\ProductSummary.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    \n</div>\n\n");
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591