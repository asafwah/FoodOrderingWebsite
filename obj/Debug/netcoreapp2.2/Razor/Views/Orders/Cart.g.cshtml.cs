#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5378c54ee0a2e7bc652c83c16adb67393c6cbbd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Cart), @"mvc.1.0.view", @"/Views/Orders/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Cart.cshtml", typeof(AspNetCore.Views_Orders_Cart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5378c54ee0a2e7bc652c83c16adb67393c6cbbd0", @"/Views/Orders/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/deleteCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/OrderCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
  
  List<Cart> carts = (List<Cart>) ViewData["carts"];
  ViewData["title"] = "My Cart";
  

#line default
#line hidden
            BeginContext(94, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(100, 17, false);
#line 7 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 81, true);
            WriteLiteral("</h2>\n<a href=\"/Home/allRecipes\" class=\"btn btn-primary\">Continue Shopping </a>\n\n");
            EndContext();
#line 10 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
 for (int i = 0; i < carts.Count(); i++)
{
    

#line default
#line hidden
            BeginContext(246, 108, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 2px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>");
            EndContext();
            BeginContext(355, 19, false);
#line 15 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
           Write(carts[i].RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(374, 22, true);
            WriteLiteral("</h3>\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 396, "\"", 422, 1);
#line 16 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
WriteAttributeValue("", 402, carts[i].PictureUrl, 402, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(423, 42, true);
            WriteLiteral(" alt=\"\" width=\"100\">\n           <p>Price: ");
            EndContext();
            BeginContext(466, 14, false);
#line 17 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
                Write(carts[i].Price);

#line default
#line hidden
            EndContext();
            BeginContext(480, 29, true);
            WriteLiteral("</p>\n           <p>Quantity: ");
            EndContext();
            BeginContext(510, 17, false);
#line 18 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
                   Write(carts[i].Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(527, 32, true);
            WriteLiteral("</p>\n           <p>Total Price: ");
            EndContext();
            BeginContext(560, 19, false);
#line 19 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
                      Write(carts[i].TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(579, 27, true);
            WriteLiteral("</p>\n           <p>Status: ");
            EndContext();
            BeginContext(607, 15, false);
#line 20 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
                 Write(carts[i].Status);

#line default
#line hidden
            EndContext();
            BeginContext(622, 67, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"card-footer\">\n\n            ");
            EndContext();
            BeginContext(689, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5378c54ee0a2e7bc652c83c16adb67393c6cbbd07399", async() => {
                BeginContext(737, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 784, "\"", 804, 1);
#line 25 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
WriteAttributeValue("", 792, carts[i].Id, 792, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(805, 90, true);
                WriteLiteral(">\n                <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\">\n            ");
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
            BeginContext(902, 43, true);
            WriteLiteral("\n            \n        </div>\n     </div>  \n");
            EndContext();
#line 31 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
}

#line default
#line hidden
#line 32 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
 if (carts.Count()==0)
{

#line default
#line hidden
            BeginContext(972, 32, true);
            WriteLiteral("    <h2>Your Cart is Empty</h2>\n");
            EndContext();
#line 35 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
}
else 
{
    int customerId = @carts[0].CustomerId;
    

#line default
#line hidden
            BeginContext(1061, 247, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5378c54ee0a2e7bc652c83c16adb67393c6cbbd010221", async() => {
                BeginContext(1108, 84, true);
                WriteLiteral("\n        <div class=\"form-group\">\n            <input type=\"hidden\" name=\"customerId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1192, "\"", 1211, 1);
#line 41 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
WriteAttributeValue("", 1200, customerId, 1200, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1212, 89, true);
                WriteLiteral(">\n        </div>\n        <input type=\"submit\" class=\"btn btn-primary\" value=\"Order\">\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(1308, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 45 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/Cart.cshtml"
}

#line default
#line hidden
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
