#pragma checksum "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bbc9c11801d022e077eb2fabf6f9ee1050d8bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\_ViewImports.cshtml"
using BoozyHops;

#line default
#line hidden
#line 2 "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\_ViewImports.cshtml"
using BoozyHops.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbc9c11801d022e077eb2fabf6f9ee1050d8bd3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26271badeefda2c9415f59a43d461550668307e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(60, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(65, 17, false);
#line 5 "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(82, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(123, 36, true);
            WriteLiteral("\r\n\r\n<h1>Hello, my name is</h1>\r\n<h1>");
            EndContext();
            BeginContext(160, 10, false);
#line 10 "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\Home\About.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(170, 11, true);
            WriteLiteral("</h1>\r\n<h1>");
            EndContext();
            BeginContext(182, 14, false);
#line 11 "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\Home\About.cshtml"
Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(196, 11, true);
            WriteLiteral("</h1>\r\n<h1>");
            EndContext();
            BeginContext(208, 10, false);
#line 12 "C:\Users\kendall rhodes\source\repos\BoozyHops\BoozyHops\Views\Home\About.cshtml"
Write(Model.Beer);

#line default
#line hidden
            EndContext();
            BeginContext(218, 65, true);
            WriteLiteral("</h1>\r\n<p>Use this area to provide additional information.</p>\r\n ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
