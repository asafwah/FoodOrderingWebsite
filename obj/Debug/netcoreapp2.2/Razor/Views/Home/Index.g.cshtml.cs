#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd2c510c9d70728b3e9d4fed4f893699fed3586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd2c510c9d70728b3e9d4fed4f893699fed3586", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/searchRecipes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
  
        string title = "Recipes Home Page";
        string RecipesList = "List of Recipes";
        var appetizerItem = (Recipe) ViewData["appetizerItem"];
        var mainCourseItem = (Recipe) ViewData["mainCourseItem"];
        var dessertItem = (Recipe) ViewData["dessertItem"];

#line default
#line hidden
            BeginContext(294, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(299, 5, false);
#line 8 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(304, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(315, 11, false);
#line 9 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
Write(RecipesList);

#line default
#line hidden
            EndContext();
            BeginContext(326, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(334, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd2c510c9d70728b3e9d4fed4f893699fed35865247", async() => {
                BeginContext(407, 209, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input type=\"text\" name = \"SearchText\" class=\"form-control\" placeholder=\"Search Recipes\">\r\n    </div>\r\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Search\">\r\n");
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
            BeginContext(623, 140, true);
            WriteLiteral("\r\n\r\n<div class=\"card\" style=\"margin-top: 20px;\">\r\n  <ul class=\"list-group list-group-flush\">\r\n    <li class=\"list-group-item\">\r\n        <h3>");
            EndContext();
            BeginContext(764, 18, false);
#line 21 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
       Write(appetizerItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(782, 31, true);
            WriteLiteral("</h3>\r\n        <p>Description: ");
            EndContext();
            BeginContext(814, 25, false);
#line 22 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
                   Write(appetizerItem.Description);

#line default
#line hidden
            EndContext();
            BeginContext(839, 30, true);
            WriteLiteral("</p>\r\n        <p>Ingredients: ");
            EndContext();
            BeginContext(870, 25, false);
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
                   Write(appetizerItem.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(895, 24, true);
            WriteLiteral("</p>\r\n        <p>Price: ");
            EndContext();
            BeginContext(920, 19, false);
#line 24 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
             Write(appetizerItem.Price);

#line default
#line hidden
            EndContext();
            BeginContext(939, 25, true);
            WriteLiteral("</p>\r\n        <p>Rating: ");
            EndContext();
            BeginContext(965, 20, false);
#line 25 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
              Write(appetizerItem.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(985, 18, true);
            WriteLiteral("</p>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1003, "\"", 1034, 1);
#line 26 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
WriteAttributeValue("", 1009, appetizerItem.PictureUrl, 1009, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1035, 166, true);
            WriteLiteral(" alt=\"\" width=\"100\"> \r\n        <p>\r\n                <a href=\"/home/appetizers\">Appetizers</a>\r\n        </p>\r\n    </li>\r\n    <li class=\"list-group-item\">\r\n        <h3>");
            EndContext();
            BeginContext(1202, 19, false);
#line 32 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
       Write(mainCourseItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 31, true);
            WriteLiteral("</h3>\r\n        <p>Description: ");
            EndContext();
            BeginContext(1253, 26, false);
#line 33 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
                   Write(mainCourseItem.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1279, 30, true);
            WriteLiteral("</p>\r\n        <p>Ingredients: ");
            EndContext();
            BeginContext(1310, 26, false);
#line 34 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
                   Write(mainCourseItem.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 24, true);
            WriteLiteral("</p>\r\n        <p>Price: ");
            EndContext();
            BeginContext(1361, 20, false);
#line 35 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
             Write(mainCourseItem.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1381, 25, true);
            WriteLiteral("</p>\r\n        <p>Rating: ");
            EndContext();
            BeginContext(1407, 21, false);
#line 36 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
              Write(mainCourseItem.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 18, true);
            WriteLiteral("</p>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1446, "\"", 1478, 1);
#line 37 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
WriteAttributeValue("", 1452, mainCourseItem.PictureUrl, 1452, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1479, 140, true);
            WriteLiteral(" alt=\"\" width=\"100\">\r\n        <p><a href=\"/home/mainCourses\">Main Courses</a></p>\r\n    </li>\r\n    <li class=\"list-group-item\">\r\n        <h3>");
            EndContext();
            BeginContext(1620, 16, false);
#line 41 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
       Write(dessertItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 31, true);
            WriteLiteral("</h3>\r\n        <p>Description: ");
            EndContext();
            BeginContext(1668, 23, false);
#line 42 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
                   Write(dessertItem.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1691, 30, true);
            WriteLiteral("</p>\r\n        <p>Ingredients: ");
            EndContext();
            BeginContext(1722, 23, false);
#line 43 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
                   Write(dessertItem.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 24, true);
            WriteLiteral("</p>\r\n        <p>Price: ");
            EndContext();
            BeginContext(1770, 17, false);
#line 44 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
             Write(dessertItem.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1787, 25, true);
            WriteLiteral("</p>\r\n        <p>Rating: ");
            EndContext();
            BeginContext(1813, 18, false);
#line 45 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
              Write(dessertItem.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 18, true);
            WriteLiteral("</p>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1849, "\"", 1878, 1);
#line 46 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/Index.cshtml"
WriteAttributeValue("", 1855, dessertItem.PictureUrl, 1855, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1879, 102, true);
            WriteLiteral(" alt=\"\" width=\"100\">\r\n        <p><a href=\"/home/desserts\">Desserts</a></p>\r\n    </li>\r\n  </ul>\r\n</div>");
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