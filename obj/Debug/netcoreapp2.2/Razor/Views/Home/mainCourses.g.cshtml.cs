#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63998b199d9c24e7f03a4c6cb3a810e7abafd3a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_mainCourses), @"mvc.1.0.view", @"/Views/Home/mainCourses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/mainCourses.cshtml", typeof(AspNetCore.Views_Home_mainCourses))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63998b199d9c24e7f03a4c6cb3a810e7abafd3a2", @"/Views/Home/mainCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_mainCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
  
string title = "Main Courses";
List<Recipe> recipes = (List<Recipe>) ViewData["recipes"];
List<Recipe> mainCourses = (List<Recipe>) ViewData["mainCourses"];

#line default
#line hidden
            BeginContext(162, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(168, 5, false);
#line 7 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(173, 35, true);
            WriteLiteral("</h2>\n<p>List of Main Courses</p>\n\n");
            EndContext();
            BeginContext(208, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63998b199d9c24e7f03a4c6cb3a810e7abafd3a25547", async() => {
                BeginContext(281, 204, true);
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
            BeginContext(492, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
#line 18 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
  for (int i = 0; i < mainCourses.Count(); i++)
{

#line default
#line hidden
            BeginContext(545, 108, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 1px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>");
            EndContext();
            BeginContext(654, 19, false);
#line 22 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
           Write(mainCourses[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(673, 28, true);
            WriteLiteral("</h3>\n            <p>Price: ");
            EndContext();
            BeginContext(702, 26, false);
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
                 Write(mainCourses[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(728, 33, true);
            WriteLiteral("</p>\n            <p>Ingredients: ");
            EndContext();
            BeginContext(762, 26, false);
#line 24 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
                       Write(mainCourses[i].Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(788, 27, true);
            WriteLiteral("</p>\n            <p>Price: ");
            EndContext();
            BeginContext(816, 20, false);
#line 25 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
                 Write(mainCourses[i].Price);

#line default
#line hidden
            EndContext();
            BeginContext(836, 28, true);
            WriteLiteral("</p>\n            <p>Rating: ");
            EndContext();
            BeginContext(865, 21, false);
#line 26 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
                  Write(mainCourses[i].Rating);

#line default
#line hidden
            EndContext();
            BeginContext(886, 23, true);
            WriteLiteral("</p>  \n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 909, "\"", 941, 1);
#line 27 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
WriteAttributeValue("", 915, mainCourses[i].PictureUrl, 915, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(942, 88, true);
            WriteLiteral(" alt=\"\" width=\"100\">      \n        </div>\n        <div class=\"card-footer\">\n            ");
            EndContext();
            BeginContext(1030, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63998b199d9c24e7f03a4c6cb3a810e7abafd3a210189", async() => {
                BeginContext(1076, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1123, "\"", 1145, 1);
#line 31 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
WriteAttributeValue("", 1131, recipes[i].Id, 1131, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1146, 96, true);
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
            BeginContext(1249, 30, true);
            WriteLiteral("\n        </div>\n     </div>  \n");
            EndContext();
#line 36 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/mainCourses.cshtml"
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
