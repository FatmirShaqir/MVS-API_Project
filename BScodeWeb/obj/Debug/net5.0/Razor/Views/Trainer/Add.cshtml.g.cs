#pragma checksum "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddcd7cabb3b0a47358b412f871a608111db7aea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainer_Add), @"mvc.1.0.view", @"/Views/Trainer/Add.cshtml")]
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
#line 1 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
using BSCodeModels_Lib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
using static BSCodeModels_Lib.Support.SuportEnums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcd7cabb3b0a47358b412f871a608111db7aea3", @"/Views/Trainer/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b204da88e87a930330d9c55ec7f32d77012be6", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainer_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trainer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trainer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
  
    Layout = "_ActionLayout";
    ViewData["Header"] = "Trainer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
 using (Html.BeginForm("Add", "Trainer", FormMethod.Post, new { @class = "row g-3", enctype="multipart/form-data"}))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model => model.Name, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.TextBoxFor(model =>  model.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.ValidationMessageFor(model =>  model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 19 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model =>  model.Description, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.TextAreaFor(model => model.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-4\">\r\n        ");
#nullable restore
#line 25 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model => model.Specialty, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.DropDownListFor(m => m.Specialty, 
             new List<SelectListItem>
            {
                new SelectListItem { Text = ((Specialty)1).ToString(), Value = "1"},
                new SelectListItem { Text = ((Specialty)2).ToString(), Value = "2"},
                new SelectListItem { Text = ((Specialty)3).ToString(), Value = "3"},
                new SelectListItem { Text = ((Specialty)4).ToString(), Value = "4"}
            }, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.Specialty, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 38 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model => model.Image, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         <input type=\"file\" id=\"ImageFile\" name=\"ImageFile\" size=\"23\" class = \"form-control\" />\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 43 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model => model.TwiterURL, new { @class = "form-label", @placeholder = "Separet points with ';'. Example: point1 some poiny; point2 some point; point3 some point" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.TextBoxFor(model => model.TwiterURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 45 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.TwiterURL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 49 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model => model.FacebookURL, new { @class = "form-label", @placeholder = "Separet points with ';'. Example: point1 some poiny; point2 some point; point3 some point" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 50 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.TextBoxFor(model => model.FacebookURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 51 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.FacebookURL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 55 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model => model.InstagramURl, new { @class = "form-label", @placeholder = "Separet points with ';'. Example: point1 some poiny; point2 some point; point3 some point" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 56 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.TextBoxFor(model => model.InstagramURl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 57 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.InstagramURl, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-8\">\r\n        ");
#nullable restore
#line 61 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.LabelFor(model => model.LinkedinURL, new { @class = "form-label", @placeholder = "Separet points with ';'. Example: point1 some poiny; point2 some point; point3 some point" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 62 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.TextBoxFor(model => model.LinkedinURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 63 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
   Write(Html.ValidationMessageFor(model => model.LinkedinURL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("     <div class=\"offset-md-2 col-md-4\">\r\n        <button type=\"submit\" class=\"btn btn-primary form-control\">Add</button>\r\n    </div>\r\n     <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddcd7cabb3b0a47358b412f871a608111db7aea314611", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 72 "C:\Users\Fatmir\OneDrive\Desktop\BsCode Final Project 4\BsCode Final Project 4\BSCodeApp\BScodeWeb\Views\Trainer\Add.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
