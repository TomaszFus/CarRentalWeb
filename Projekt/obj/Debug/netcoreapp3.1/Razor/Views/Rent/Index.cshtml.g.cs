#pragma checksum "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba83d2152507bd7d07384404a5542b3a9f678b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rent_Index), @"mvc.1.0.view", @"/Views/Rent/Index.cshtml")]
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
#line 1 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\_ViewImports.cshtml"
using Projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\_ViewImports.cshtml"
using Projekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba83d2152507bd7d07384404a5542b3a9f678b5d", @"/Views/Rent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ccb9a0a85e2b383b463914ff60e93aa736b684", @"/Views/_ViewImports.cshtml")]
    public class Views_Rent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projekt.Models.RentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Wypożyczenia</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba83d2152507bd7d07384404a5542b3a9f678b5d3625", async() => {
                WriteLiteral("Wypożycz samochód");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Car.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Car.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.ActionLink("Zakończ", "Edit", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 47 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
           Write(Html.ActionLink("Szczegóły", "Details", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "G:\Programowanie\C#\.net core\Projekt\Projekt\Views\Rent\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projekt.Models.RentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
