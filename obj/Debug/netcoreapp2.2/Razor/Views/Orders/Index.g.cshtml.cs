#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99d974624b5ff60ddc56456817e839bde628452c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d974624b5ff60ddc56456817e839bde628452c", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/SearchOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
  
    var orders = (List<Order>)ViewData["orders"];
    var allOrderRecipes = (List<OrderRecipes>)ViewData["allOrderRecipes"];
    ViewData["title"] = "Admin Orders Page";

#line default
#line hidden
            BeginContext(175, 16, true);
            WriteLiteral("<h2>Orders</h2>\n");
            EndContext();
            BeginContext(191, 288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99d974624b5ff60ddc56456817e839bde628452c5576", async() => {
                BeginContext(265, 207, true);
                WriteLiteral("\n    <div class=\"form-group\">\n        <input type=\"int\" name = \"SearchInt\" class=\"form-control\" placeholder=\"Search Orders by ID\">\n    </div>\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Search\">\n");
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
            BeginContext(479, 72, true);
            WriteLiteral("\n\n<a href=\"/orders/addOrder\" class=\"btn btn-primary\">Add New Order</a>\n\n");
            EndContext();
#line 16 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
 for (int i = 0; i < orders.Count(); i++)
{

#line default
#line hidden
            BeginContext(595, 112, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 2px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>ID: ");
            EndContext();
            BeginContext(708, 12, false);
#line 20 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
               Write(orders[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(720, 34, true);
            WriteLiteral("</h3>\n            <p>Customer ID: ");
            EndContext();
            BeginContext(755, 20, false);
#line 21 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
                       Write(orders[i].CustomerId);

#line default
#line hidden
            EndContext();
            BeginContext(775, 33, true);
            WriteLiteral("</p>\n           <p>CreationDate: ");
            EndContext();
            BeginContext(809, 22, false);
#line 22 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
                       Write(orders[i].CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(831, 34, true);
            WriteLiteral("</p>\n           <p>Delevery Date: ");
            EndContext();
            BeginContext(866, 22, false);
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
                        Write(orders[i].DeleveryDate);

#line default
#line hidden
            EndContext();
            BeginContext(888, 27, true);
            WriteLiteral("</p>\n           <p>Status: ");
            EndContext();
            BeginContext(916, 16, false);
#line 24 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
                 Write(orders[i].Status);

#line default
#line hidden
            EndContext();
            BeginContext(932, 25, true);
            WriteLiteral("</p>\n           <p>Cost: ");
            EndContext();
            BeginContext(958, 14, false);
#line 25 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
               Write(orders[i].Cost);

#line default
#line hidden
            EndContext();
            BeginContext(972, 42, true);
            WriteLiteral("</p>\n            <h3>Order Recipes: </h3>\n");
            EndContext();
#line 27 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
            for (int e = 0; e < allOrderRecipes.Count(); e++)
           {

                if (@allOrderRecipes[e].OrderId == @orders[i].Id)
                {

#line default
#line hidden
            BeginContext(1174, 28, true);
            WriteLiteral("                        <h3>");
            EndContext();
            BeginContext(1203, 29, false);
#line 32 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
                       Write(allOrderRecipes[e].RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(1232, 43, true);
            WriteLiteral("</h3>\n                        <p>Quantity: ");
            EndContext();
            BeginContext(1276, 27, false);
#line 33 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
                                Write(allOrderRecipes[e].Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 34 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
                }
           }

#line default
#line hidden
            BeginContext(1339, 73, true);
            WriteLiteral("           \n        </div>\n        <div class=\"card-footer\">\n            ");
            EndContext();
            BeginContext(1412, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99d974624b5ff60ddc56456817e839bde628452c11590", async() => {
                BeginContext(1460, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1507, "\"", 1528, 1);
#line 40 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
WriteAttributeValue("", 1515, orders[i].Id, 1515, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1529, 91, true);
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
            BeginContext(1627, 14, true);
            WriteLiteral("\n\n            ");
            EndContext();
            BeginContext(1641, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99d974624b5ff60ddc56456817e839bde628452c13856", async() => {
                BeginContext(1690, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1737, "\"", 1758, 1);
#line 45 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
WriteAttributeValue("", 1745, orders[i].Id, 1745, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1759, 90, true);
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
            BeginContext(1856, 30, true);
            WriteLiteral("\n        </div>\n     </div>  \n");
            EndContext();
#line 50 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1888, 2, true);
            WriteLiteral("\n\n");
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
