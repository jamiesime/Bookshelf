#pragma checksum "C:\Users\jamie\CodeScratches\Bookshelf\Views\Home\FakeRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59fd2b3d14f1b1e6c50679445396d82d30e4d630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FakeRoute), @"mvc.1.0.view", @"/Views/Home/FakeRoute.cshtml")]
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
#line 1 "C:\Users\jamie\CodeScratches\Bookshelf\Views\_ViewImports.cshtml"
using Bookshelf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jamie\CodeScratches\Bookshelf\Views\_ViewImports.cshtml"
using Bookshelf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59fd2b3d14f1b1e6c50679445396d82d30e4d630", @"/Views/Home/FakeRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d929040324e9e303d6c4eb190668787bba0f2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FakeRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jamie\CodeScratches\Bookshelf\Views\Home\FakeRoute.cshtml"
  
    ViewData["Title"] = "Fake Zone";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1>This is a fake route</h1>\r\n    <p>from hell</p>\r\n    <br>\r\n");
#nullable restore
#line 10 "C:\Users\jamie\CodeScratches\Bookshelf\Views\Home\FakeRoute.cshtml"
      
        int initial = (int)ViewData["MultiplyThis"];
        int result = (int)ViewData["MultiplyThis"] * 10;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Multiplying ");
#nullable restore
#line 14 "C:\Users\jamie\CodeScratches\Bookshelf\Views\Home\FakeRoute.cshtml"
              Write(initial);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by 10 gives: ");
#nullable restore
#line 14 "C:\Users\jamie\CodeScratches\Bookshelf\Views\Home\FakeRoute.cshtml"
                                    Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
