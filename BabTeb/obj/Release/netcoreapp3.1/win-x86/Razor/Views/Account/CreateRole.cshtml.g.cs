#pragma checksum "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6966196a5cb3f241bf10f65be72a0db56de7f10e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CreateRole), @"mvc.1.0.view", @"/Views/Account/CreateRole.cshtml")]
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
#nullable restore
#line 1 "F:\BabTeb\BabTeb\Views\_ViewImports.cshtml"
using BabTeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\BabTeb\BabTeb\Views\_ViewImports.cshtml"
using BabTeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6966196a5cb3f241bf10f65be72a0db56de7f10e", @"/Views/Account/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fdaad658247010fb03120532e5c3760fcff647", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CreateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
  
    ViewBag.Title = "CreateRole";
    Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>ایجاد نقش</h2>\n");
#nullable restore
#line 8 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
Write(Html.ActionLink("فهرست نقش ها", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 8 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
                                       Write(Html.ActionLink("مدیریت نقش کاربر", "ManageUserRoles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr/>\n");
#nullable restore
#line 10 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n       نام نقش\n    </div>\n    <p>\n        ");
#nullable restore
#line 19 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
   Write(Html.TextBox("RoleName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6966196a5cb3f241bf10f65be72a0db56de7f10e4521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 20 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n    <input type=\"submit\" value=\"ذخیره\" />\n");
#nullable restore
#line 23 "F:\BabTeb\BabTeb\Views\Account\CreateRole.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
