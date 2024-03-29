#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d62c36cbb5252073f231ed6794572bc8619c8b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_SearchOrders), @"mvc.1.0.view", @"/Views/Orders/SearchOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/SearchOrders.cshtml", typeof(AspNetCore.Views_Orders_SearchOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d62c36cbb5252073f231ed6794572bc8619c8b5", @"/Views/Orders/SearchOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_SearchOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/SearchOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/updateOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/deleteOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
  
string title = "Admin Search Orders";
List<Order> orders = (List<Order>) ViewData["orders"];


#line default
#line hidden
            BeginContext(99, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(104, 5, false);
#line 6 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(109, 28, true);
            WriteLiteral("</h2>\n<p>List of Orders</p>\n");
            EndContext();
#line 8 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
 if(orders.Count()==0)
{

#line default
#line hidden
            BeginContext(162, 25, true);
            WriteLiteral("<h3>No Orders Found</h3>\n");
            EndContext();
#line 11 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
}

#line default
#line hidden
            BeginContext(189, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d62c36cbb5252073f231ed6794572bc8619c8b56242", async() => {
                BeginContext(263, 206, true);
                WriteLiteral("\n    <dive class=\"form-group\">\n        <input type=\"number\" name = \"SearchInt\" class=\"form-control\" placeholder=\"Search Orders\">\n    </dive>\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Search\">\n");
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
            BeginContext(476, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 19 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
  for (int i = 0; i < orders.Count(); i++)
{

#line default
#line hidden
            BeginContext(523, 108, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 1px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>");
            EndContext();
            BeginContext(632, 12, false);
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
           Write(orders[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(644, 26, true);
            WriteLiteral(" </h3>\n            <p> ID ");
            EndContext();
            BeginContext(671, 22, false);
#line 24 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
              Write(orders[i].CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(693, 27, true);
            WriteLiteral("</p>\n            <p>Email: ");
            EndContext();
            BeginContext(721, 22, false);
#line 25 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
                 Write(orders[i].DeleveryDate);

#line default
#line hidden
            EndContext();
            BeginContext(743, 30, true);
            WriteLiteral("</p>\n            <p>Password: ");
            EndContext();
            BeginContext(774, 20, false);
#line 26 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
                    Write(orders[i].CustomerId);

#line default
#line hidden
            EndContext();
            BeginContext(794, 27, true);
            WriteLiteral("</p>\n            <p>Phone: ");
            EndContext();
            BeginContext(822, 16, false);
#line 27 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
                 Write(orders[i].Status);

#line default
#line hidden
            EndContext();
            BeginContext(838, 27, true);
            WriteLiteral("</p>\n            <p>Phone: ");
            EndContext();
            BeginContext(866, 14, false);
#line 28 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
                 Write(orders[i].Cost);

#line default
#line hidden
            EndContext();
            BeginContext(880, 66, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"card-footer\">\n            ");
            EndContext();
            BeginContext(946, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d62c36cbb5252073f231ed6794572bc8619c8b510776", async() => {
                BeginContext(994, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1041, "\"", 1062, 1);
#line 32 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
WriteAttributeValue("", 1049, orders[i].Id, 1049, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1063, 91, true);
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
            BeginContext(1161, 14, true);
            WriteLiteral("\n\n            ");
            EndContext();
            BeginContext(1175, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d62c36cbb5252073f231ed6794572bc8619c8b513048", async() => {
                BeginContext(1224, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1271, "\"", 1292, 1);
#line 37 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
WriteAttributeValue("", 1279, orders[i].Id, 1279, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1293, 90, true);
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
            BeginContext(1390, 30, true);
            WriteLiteral("\n        </div>\n     </div>  \n");
            EndContext();
#line 42 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/SearchOrders.cshtml"
}

#line default
#line hidden
            BeginContext(1422, 1, true);
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
