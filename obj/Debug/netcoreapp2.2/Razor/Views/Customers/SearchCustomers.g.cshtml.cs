#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af62f7caa88411cdc0e5c6c64efb564a9d3894ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_SearchCustomers), @"mvc.1.0.view", @"/Views/Customers/SearchCustomers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/SearchCustomers.cshtml", typeof(AspNetCore.Views_Customers_SearchCustomers))]
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/_ViewImports.cshtml"
using FoodOrderingWebsite;

#line default
#line hidden
#line 2 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/_ViewImports.cshtml"
using FoodOrderingWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af62f7caa88411cdc0e5c6c64efb564a9d3894ce", @"/Views/Customers/SearchCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_SearchCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Customers/SearchCustomers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Customers/updateCustomer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Customers/deleteCustomer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
  
string title = "Admin Search Customer";
List<Customer> customers = (List<Customer>) ViewData["customers"];


#line default
#line hidden
            BeginContext(113, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(118, 5, false);
#line 6 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(123, 31, true);
            WriteLiteral("</h2>\n<p>List of Customers</p>\n");
            EndContext();
#line 8 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
 if(customers.Count()==0)
{

#line default
#line hidden
            BeginContext(182, 26, true);
            WriteLiteral("<h3>No Recipes Found</h3>\n");
            EndContext();
#line 11 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
}

#line default
#line hidden
            BeginContext(210, 295, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af62f7caa88411cdc0e5c6c64efb564a9d3894ce6348", async() => {
                BeginContext(290, 208, true);
                WriteLiteral("\n    <dive class=\"form-group\">\n        <input type=\"text\" name = \"SearchText\" class=\"form-control\" placeholder=\"Search Customers\">\n    </dive>\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Search\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(505, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 19 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
  for (int i = 0; i < customers.Count(); i++)
{

#line default
#line hidden
            BeginContext(555, 108, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 1px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>");
            EndContext();
            BeginContext(664, 22, false);
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
           Write(customers[i].FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(686, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(688, 21, false);
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
                                   Write(customers[i].LastName);

#line default
#line hidden
            EndContext();
            BeginContext(709, 25, true);
            WriteLiteral("</h3>\n            <p> ID ");
            EndContext();
            BeginContext(735, 15, false);
#line 24 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
              Write(customers[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(750, 27, true);
            WriteLiteral("</p>\n            <p>Email: ");
            EndContext();
            BeginContext(778, 18, false);
#line 25 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
                 Write(customers[i].Email);

#line default
#line hidden
            EndContext();
            BeginContext(796, 30, true);
            WriteLiteral("</p>\n            <p>Password: ");
            EndContext();
            BeginContext(827, 21, false);
#line 26 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
                    Write(customers[i].Password);

#line default
#line hidden
            EndContext();
            BeginContext(848, 27, true);
            WriteLiteral("</p>\n            <p>Phone: ");
            EndContext();
            BeginContext(876, 18, false);
#line 27 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
                 Write(customers[i].Phone);

#line default
#line hidden
            EndContext();
            BeginContext(894, 66, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"card-footer\">\n            ");
            EndContext();
            BeginContext(960, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af62f7caa88411cdc0e5c6c64efb564a9d3894ce10927", async() => {
                BeginContext(1014, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1061, "\"", 1085, 1);
#line 31 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
WriteAttributeValue("", 1069, customers[i].Id, 1069, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1086, 91, true);
                WriteLiteral(">\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Update\">\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1184, 14, true);
            WriteLiteral("\n\n            ");
            EndContext();
            BeginContext(1198, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af62f7caa88411cdc0e5c6c64efb564a9d3894ce13209", async() => {
                BeginContext(1253, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1300, "\"", 1324, 1);
#line 36 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
WriteAttributeValue("", 1308, customers[i].Id, 1308, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1325, 90, true);
                WriteLiteral(">\n                <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\">\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1422, 30, true);
            WriteLiteral("\n        </div>\n     </div>  \n");
            EndContext();
#line 41 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Customers/SearchCustomers.cshtml"
}

#line default
#line hidden
            BeginContext(1454, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
