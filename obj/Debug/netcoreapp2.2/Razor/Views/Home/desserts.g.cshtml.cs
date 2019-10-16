#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76fbb569a4fd74704c8df7574d9492be2c5f3e0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_desserts), @"mvc.1.0.view", @"/Views/Home/desserts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/desserts.cshtml", typeof(AspNetCore.Views_Home_desserts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76fbb569a4fd74704c8df7574d9492be2c5f3e0d", @"/Views/Home/desserts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_desserts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/searchRecipes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/addToOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
  
string title = "Desserts";
List<Recipe> desserts = (List<Recipe>) ViewData["desserts"];
List<Recipe> recipes = (List<Recipe>) ViewData["recipes"];

#line default
#line hidden
            BeginContext(152, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(158, 5, false);
#line 7 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(163, 31, true);
            WriteLiteral("</h2>\n<p>List of Desserts</p>\n\n");
            EndContext();
            BeginContext(194, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76fbb569a4fd74704c8df7574d9492be2c5f3e0d5506", async() => {
                BeginContext(267, 204, true);
                WriteLiteral("\n    <div class=\"form-group\">\n        <input type=\"text\" name = \"SearchText\" class=\"form-control\" placeholder=\"Search Recipes\">\n    </div>\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Search\">\n");
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
            BeginContext(478, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
#line 18 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
  for (int i = 0; i < desserts.Count(); i++)
{

#line default
#line hidden
            BeginContext(528, 108, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 1px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>");
            EndContext();
            BeginContext(637, 16, false);
#line 22 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
           Write(desserts[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(653, 28, true);
            WriteLiteral("</h3>\n            <p>Price: ");
            EndContext();
            BeginContext(682, 23, false);
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
                 Write(desserts[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(705, 33, true);
            WriteLiteral("</p>\n            <p>Ingredients: ");
            EndContext();
            BeginContext(739, 23, false);
#line 24 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
                       Write(desserts[i].Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(762, 27, true);
            WriteLiteral("</p>\n            <p>Price: ");
            EndContext();
            BeginContext(790, 17, false);
#line 25 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
                 Write(desserts[i].Price);

#line default
#line hidden
            EndContext();
            BeginContext(807, 28, true);
            WriteLiteral("</p>\n            <p>Rating: ");
            EndContext();
            BeginContext(836, 18, false);
#line 26 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
                  Write(desserts[i].Rating);

#line default
#line hidden
            EndContext();
            BeginContext(854, 22, true);
            WriteLiteral("</p> \n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 876, "\"", 905, 1);
#line 27 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
WriteAttributeValue("", 882, desserts[i].PictureUrl, 882, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(906, 89, true);
            WriteLiteral(" alt=\"\" width=\"100\">       \n        </div>\n        <div class=\"card-footer\">\n            ");
            EndContext();
            BeginContext(995, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76fbb569a4fd74704c8df7574d9492be2c5f3e0d10105", async() => {
                BeginContext(1041, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1088, "\"", 1111, 1);
#line 31 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
WriteAttributeValue("", 1096, desserts[i].Id, 1096, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1112, 96, true);
                WriteLiteral(">\n                <input type=\"submit\" class=\"btn btn-danger\" value=\"Add To Order\">\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1215, 30, true);
            WriteLiteral("\n        </div>\n     </div>  \n");
            EndContext();
#line 36 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/desserts.cshtml"
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
