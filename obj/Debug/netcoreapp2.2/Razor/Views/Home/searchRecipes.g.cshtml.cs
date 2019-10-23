#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f196f52c2c6fd1496009f70208aa3ab935e67d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_searchRecipes), @"mvc.1.0.view", @"/Views/Home/searchRecipes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/searchRecipes.cshtml", typeof(AspNetCore.Views_Home_searchRecipes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f196f52c2c6fd1496009f70208aa3ab935e67d9", @"/Views/Home/searchRecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_searchRecipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/addToCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
  
string title = "Search Recipes Page";
List<Recipe> recipes = (List<Recipe>) ViewData["recipes"];

#line default
#line hidden
            BeginContext(102, 63, true);
            WriteLiteral("<a href=\"/Orders/Cart\" class=\"btn btn-primary\">My Cart</a>\n<h2>");
            EndContext();
            BeginContext(166, 5, false);
#line 6 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(171, 29, true);
            WriteLiteral("</h2>\n<p>List of Recipes</p>\n");
            EndContext();
#line 8 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
 if(recipes.Count()==0)
{

#line default
#line hidden
            BeginContext(226, 26, true);
            WriteLiteral("<h3>No Recipes Found</h3>\n");
            EndContext();
#line 11 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
}

#line default
#line hidden
#line 12 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
  for (int i = 0; i < recipes.Count(); i++)
{

#line default
#line hidden
            BeginContext(300, 108, true);
            WriteLiteral("     <div class=\"card\" style=\"border: 1px solid lightgrey\">\n        <div class=\"card-body\">\n            <h3>");
            EndContext();
            BeginContext(409, 15, false);
#line 16 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
           Write(recipes[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(424, 31, true);
            WriteLiteral("</h3>\n            <p>Category: ");
            EndContext();
            BeginContext(456, 19, false);
#line 17 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
                    Write(recipes[i].Category);

#line default
#line hidden
            EndContext();
            BeginContext(475, 27, true);
            WriteLiteral("</p>\n            <p>Price: ");
            EndContext();
            BeginContext(503, 22, false);
#line 18 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
                 Write(recipes[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(525, 33, true);
            WriteLiteral("</p>\n            <p>Ingredients: ");
            EndContext();
            BeginContext(559, 22, false);
#line 19 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
                       Write(recipes[i].Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(581, 27, true);
            WriteLiteral("</p>\n            <p>Price: ");
            EndContext();
            BeginContext(609, 16, false);
#line 20 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
                 Write(recipes[i].Price);

#line default
#line hidden
            EndContext();
            BeginContext(625, 28, true);
            WriteLiteral("</p>\n            <p>Rating: ");
            EndContext();
            BeginContext(654, 17, false);
#line 21 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
                  Write(recipes[i].Rating);

#line default
#line hidden
            EndContext();
            BeginContext(671, 21, true);
            WriteLiteral("</p>\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 692, "\"", 720, 1);
#line 22 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
WriteAttributeValue("", 698, recipes[i].PictureUrl, 698, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(721, 82, true);
            WriteLiteral(" alt=\"\" width=\"100\">\n        </div>\n        <div class=\"card-footer\">\n            ");
            EndContext();
            BeginContext(803, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f196f52c2c6fd1496009f70208aa3ab935e67d97900", async() => {
                BeginContext(850, 47, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 897, "\"", 919, 1);
#line 26 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
WriteAttributeValue("", 905, recipes[i].Id, 905, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(920, 99, true);
                WriteLiteral(">\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Add To My Cart\">\n            ");
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
            BeginContext(1026, 30, true);
            WriteLiteral("\n        </div>\n     </div>  \n");
            EndContext();
#line 31 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Home/searchRecipes.cshtml"
}

#line default
#line hidden
            BeginContext(1058, 1, true);
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
