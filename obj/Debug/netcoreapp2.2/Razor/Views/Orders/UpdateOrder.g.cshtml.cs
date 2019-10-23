#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3028c5dcacee55e1809a5936ce2156ea3ad42acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_UpdateOrder), @"mvc.1.0.view", @"/Views/Orders/UpdateOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/UpdateOrder.cshtml", typeof(AspNetCore.Views_Orders_UpdateOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3028c5dcacee55e1809a5936ce2156ea3ad42acf", @"/Views/Orders/UpdateOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_UpdateOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/updateOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
  
  ViewData["title"] = "Update Order";
  Order order = (Order)ViewData["order"];

#line default
#line hidden
            BeginContext(85, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(90, 17, false);
#line 5 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
            EndContext();
            BeginContext(107, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
            BeginContext(114, 1901, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3028c5dcacee55e1809a5936ce2156ea3ad42acf4824", async() => {
                BeginContext(193, 77, true);
                WriteLiteral("\n    <div class=\"form-group\">\n        <input readonly type=\"number\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 270, "\"", 287, 1);
#line 9 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
WriteAttributeValue("", 278, order.Id, 278, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(288, 130, true);
                WriteLiteral(" class=form-control placeholder=\"Order ID\">\n    </div>\n    <div class=\"form-group\">\n        <input type=\"text\" name=\"CreationDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 418, "\"", 445, 1);
#line 12 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
WriteAttributeValue("", 426, order.CreationDate, 426, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(446, 141, true);
                WriteLiteral(" class=form-control placeholder=\"Order Creation Date\">\n    </div>\n    <div class=\"form-group\">\n        <input type=\"text\" name=\"DeleveryDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 587, "\"", 614, 1);
#line 15 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
WriteAttributeValue("", 595, order.DeleveryDate, 595, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(615, 141, true);
                WriteLiteral(" class=form-control placeholder=\"Order Delevery Date\">\n    </div>\n    <div class=\"form-group\">\n        <input type=\"number\" name=\"CustomerId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 756, "\"", 781, 1);
#line 18 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
WriteAttributeValue("", 764, order.CustomerId, 764, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(782, 133, true);
                WriteLiteral(" class=form-control placeholder=\"Order Customer Id\">\n    </div>\n    <div class=\"form-group\">\n        <input type=\"double\" name=\"Cost\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 915, "\"", 934, 1);
#line 21 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
WriteAttributeValue("", 923, order.Cost, 923, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(935, 70, true);
                WriteLiteral(" class=form-control placeholder=\"Order Cost\">\n    </div>\n\n    \n    \n\n\n");
                EndContext();
#line 28 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
     if (@order.Status=="Ready")
    {

#line default
#line hidden
                BeginContext(1044, 273, true);
                WriteLiteral(@"        <div class=""form-group"">  
        <input type=""radio"" name=""Status"" value=""Pending""> Pending<br>
        <input type=""radio"" name=""Status"" value=""Approved""> Approved<br>
        <input type=""radio"" name=""Status"" value=""Ready""checked> Ready<br><br>
        </div> 
");
                EndContext();
#line 35 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
    }
    else if (@order.Status=="Approved")
    {

#line default
#line hidden
                BeginContext(1369, 274, true);
                WriteLiteral(@"        <div class=""form-group"">  
        <input type=""radio"" name=""Status"" value=""Pending""> Pending<br>
        <input type=""radio"" name=""Status"" value=""Approved"" checked> Approved<br>
        <input type=""radio"" name=""Status"" value=""Ready""> Ready<br><br>
        </div> 
");
                EndContext();
#line 43 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(1664, 274, true);
                WriteLiteral(@"        <div class=""form-group"">  
        <input type=""radio"" name=""Status"" value=""Pending"" checked> Pending<br>
        <input type=""radio"" name=""Status"" value=""Approved""> Approved<br>
        <input type=""radio"" name=""Status"" value=""Ready""> Ready<br><br>
        </div> 
");
                EndContext();
#line 51 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Orders/UpdateOrder.cshtml"
    }

#line default
#line hidden
                BeginContext(1944, 64, true);
                WriteLiteral("\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Save\">\n");
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
