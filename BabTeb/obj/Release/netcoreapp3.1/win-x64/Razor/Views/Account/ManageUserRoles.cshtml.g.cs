#pragma checksum "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eed57183e53fa8afdad18727940b55c3642ad9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ManageUserRoles), @"mvc.1.0.view", @"/Views/Account/ManageUserRoles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eed57183e53fa8afdad18727940b55c3642ad9b", @"/Views/Account/ManageUserRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fdaad658247010fb03120532e5c3760fcff647", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ManageUserRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
  
    ViewBag.Title = "ManageUserRoles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Manage User Roles</h2>\r\n");
#nullable restore
#line 7 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
Write(Html.ActionLink("Create New Role", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 7 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
                                           Write(Html.ActionLink("Manage User Role", "ManageUserRoles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr/>\r\n\r\n<h2>Role Add to User</h2>\r\n\r\n");
#nullable restore
#line 12 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
 using (Html.BeginForm("RoleAddToUser", "Account"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Username : ");
#nullable restore
#line 18 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
              Write(Html.TextBox("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Role Name: ");
#nullable restore
#line 19 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
              Write(Html.DropDownList("RoleName", (IEnumerable <SelectListItem>) ViewBag.Roles, "Select ..."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 24 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr/>\r\n\r\n<h3>Get Roles for a User</h3>\r\n");
#nullable restore
#line 28 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
 using (Html.BeginForm("GetRoles", "Account"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Username : ");
#nullable restore
#line 32 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
              Write(Html.TextBox("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Get Roles for this User\" />\r\n    </p>\r\n");
#nullable restore
#line 35 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 38 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
 if (ViewBag.RolesForThisUser != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"background-color:yellow;\">\r\n        <h3>Roles for this user </h3>\r\n        <ol>\r\n");
#nullable restore
#line 43 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
             foreach (ViewResult s in ViewBag.RolesForThisUser)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 45 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
               Write(s.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 46 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n    </div>\r\n");
#nullable restore
#line 49 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n<h3>Delete A User from a Role</h3>\r\n\r\n");
#nullable restore
#line 54 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
 using (Html.BeginForm("DeleteRoleForUser", "Roles"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Username : ");
#nullable restore
#line 60 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
              Write(Html.TextBox("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Role Name: ");
#nullable restore
#line 61 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
              Write(Html.DropDownList("RoleName", (IEnumerable<SelectListItem>)ViewBag.Roles, "Select ..."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Delete this user from Role\" />\r\n");
#nullable restore
#line 66 "F:\BabTeb\BabTeb\Views\Account\ManageUserRoles.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
