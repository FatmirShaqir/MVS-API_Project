#pragma checksum "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Shared\_ActionLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ee6b5634b8a215900b74b04859c96110b542fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ActionLayout), @"mvc.1.0.view", @"/Views/Shared/_ActionLayout.cshtml")]
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
#line 1 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\_ViewImports.cshtml"
using BScodeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\_ViewImports.cshtml"
using BScodeWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\_ViewImports.cshtml"
using BSCodeModels_Lib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\_ViewImports.cshtml"
using static BSCodeModels_Lib.Support.SuportEnums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ee6b5634b8a215900b74b04859c96110b542fd", @"/Views/Shared/_ActionLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b204da88e87a930330d9c55ec7f32d77012be6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ActionLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Shared\_ActionLayout.cshtml"
  
    Layout = "_WebContentLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<Header style=\"margin-top: 5vh \">\r\n    <h3 class=\"text-center\">");
#nullable restore
#line 6 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Shared\_ActionLayout.cshtml"
                       Write(ViewData["Header"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 6 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Shared\_ActionLayout.cshtml"
                                              Write(ViewContext.RouteData.Values["Action"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</Header>\r\n\r\n<div class=\"container\" style=\"margin-top: 5vh \">\r\n    ");
#nullable restore
#line 10 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Shared\_ActionLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Shared\_ActionLayout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
