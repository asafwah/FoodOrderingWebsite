#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53c176d90feaf2a0edc1bd78335ed543483d3915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_MyOrders), @"mvc.1.0.view", @"/Views/Orders/MyOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/MyOrders.cshtml", typeof(AspNetCore.Views_Orders_MyOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c176d90feaf2a0edc1bd78335ed543483d3915", @"/Views/Orders/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/updateMyOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/deleteMyOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
  
    var myOrders = (List<Order>)ViewData["myOrders"];
    var allOrderRecipes = (List<OrderRecipes>)ViewData["allOrderRecipes"];
    ViewData["title"] = "My Orders";

#line default
#line hidden
            BeginContext(171, 19, true);
            WriteLiteral("<h2>My Orders</h2>\n");
            EndContext();
#line 7 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
 if (myOrders.Count()== 0)
{

#line default
#line hidden
            BeginContext(219, 55, true);
            WriteLiteral("    <h3>You Don\'t Have Any Order, check Your Cart</h3>\n");
            EndContext();
#line 10 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
}

#line default
#line hidden
            BeginContext(276, 60, true);
            WriteLiteral("<a href=\"/Orders/Cart\" class=\"btn btn-primary\">My Cart</a>\n\n");
            EndContext();
#line 13 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
 for (int i = 0; i < myOrders.Count(); i++)
{

#line default
#line hidden
            BeginContext(382, 112, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 2px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>ID: ");
            EndContext();
            BeginContext(495, 14, false);
#line 17 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
               Write(myOrders[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(509, 34, true);
            WriteLiteral("</h3>\n           <p>CreationDate: ");
            EndContext();
            BeginContext(544, 24, false);
#line 18 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
                       Write(myOrders[i].CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(568, 34, true);
            WriteLiteral("</p>\n           <p>Delevery Date: ");
            EndContext();
            BeginContext(603, 24, false);
#line 19 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
                        Write(myOrders[i].DeleveryDate);

#line default
#line hidden
            EndContext();
            BeginContext(627, 27, true);
            WriteLiteral("</p>\n           <p>Status: ");
            EndContext();
            BeginContext(655, 18, false);
#line 20 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
                 Write(myOrders[i].Status);

#line default
#line hidden
            EndContext();
            BeginContext(673, 25, true);
            WriteLiteral("</p>\n           <p>Cost: ");
            EndContext();
            BeginContext(699, 16, false);
#line 21 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
               Write(myOrders[i].Cost);

#line default
#line hidden
            EndContext();
            BeginContext(715, 42, true);
            WriteLiteral("</p>\n            <h3>Order Recipes: </h3>\n");
            EndContext();
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
            for (int e = 0; e < allOrderRecipes.Count(); e++)
           {

                if (@allOrderRecipes[e].OrderId == @myOrders[i].Id)
                {

#line default
#line hidden
            BeginContext(919, 28, true);
            WriteLiteral("                        <h3>");
            EndContext();
            BeginContext(948, 29, false);
#line 28 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
                       Write(allOrderRecipes[e].RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(977, 43, true);
            WriteLiteral("</h3>\n                        <p>Quantity: ");
            EndContext();
            BeginContext(1021, 27, false);
#line 29 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
                                Write(allOrderRecipes[e].Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 30 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
                }
           }

#line default
#line hidden
            BeginContext(1084, 73, true);
            WriteLiteral("           \n        </div>\n        <div class=\"card-footer\">\n            ");
            EndContext();
            BeginContext(1157, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53c176d90feaf2a0edc1bd78335ed543483d39159064", async() => {
                BeginContext(1207, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1254, "\"", 1277, 1);
#line 36 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
WriteAttributeValue("", 1262, myOrders[i].Id, 1262, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1278, 91, true);
                WriteLiteral(">\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Update\">\n            ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1376, 14, true);
            WriteLiteral("\n\n            ");
            EndContext();
            BeginContext(1390, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53c176d90feaf2a0edc1bd78335ed543483d391511334", async() => {
                BeginContext(1441, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1488, "\"", 1511, 1);
#line 41 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
WriteAttributeValue("", 1496, myOrders[i].Id, 1496, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1512, 90, true);
                WriteLiteral(">\n                <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\">\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1609, 30, true);
            WriteLiteral("\n        </div>\n     </div>  \n");
            EndContext();
#line 46 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/MyOrders.cshtml"
}

#line default
#line hidden
            BeginContext(1641, 2, true);
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
