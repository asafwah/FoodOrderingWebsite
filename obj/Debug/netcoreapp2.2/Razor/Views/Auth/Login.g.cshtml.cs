#pragma checksum "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b98d0433da89d574120a621e7edb66136df0701c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Login.cshtml", typeof(AspNetCore.Views_Auth_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98d0433da89d574120a621e7edb66136df0701c", @"/Views/Auth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457fe65f77fd7d18ac0776cb979b9661a0161b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/auth/login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml"
  
  var error = (bool)ViewData["error"];
  var loginSuccessfull = (bool)ViewData["loginSuccessfull"];
  var userNotFound = (bool)ViewData["userNotFound"];

#line default
#line hidden
            BeginContext(158, 22, true);
            WriteLiteral("\n<h2>Login Page</h2>\n\n");
            EndContext();
#line 9 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml"
 if(error)
{

#line default
#line hidden
            BeginContext(193, 82, true);
            WriteLiteral("  <div class=\"alert alert-error\" role=\"alert\">\n    Something went wrong!\n  </div>\n");
            EndContext();
#line 14 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml"
}

#line default
#line hidden
            BeginContext(277, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 16 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml"
 if(loginSuccessfull)
{

#line default
#line hidden
            BeginContext(302, 71, true);
            WriteLiteral("  <div class=\"alert alert-error\" role=\"alert\">\n    Logged in!\n  </div>\n");
            EndContext();
#line 21 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml"
}

#line default
#line hidden
            BeginContext(375, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 23 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml"
 if(userNotFound)
{

#line default
#line hidden
            BeginContext(396, 126, true);
            WriteLiteral("  <div class=\"alert alert-error\" role=\"alert\">\n    User not found. Please <a href=\"/auth/register\">register</a> here\n  </div>\n");
            EndContext();
#line 28 "/Users/asafwah/Desktop/FoodOrderingWebsite/Views/Auth/Login.cshtml"
}

#line default
#line hidden
            BeginContext(524, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(526, 369, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b98d0433da89d574120a621e7edb66136df0701c5764", async() => {
                BeginContext(567, 321, true);
                WriteLiteral(@"
  <div class=""form-group"">
    <input type=""email"" class=""form-control"" name=""email"" placeholder=""Email"" required>
  </div>
  <div class=""form-group"">
    <input type=""password"" class=""form-control"" name=""password"" placeholder=""Password"" required>
  </div>
  <button type=""submit"" class=""btn btn-primary"">Login</button>
");
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
            BeginContext(895, 103, true);
            WriteLiteral("\n\n<div class=\"alert alert-error\" role=\"alert\">\n     <a href=\"/auth/register\">Register Here</a>\n  </div>");
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
