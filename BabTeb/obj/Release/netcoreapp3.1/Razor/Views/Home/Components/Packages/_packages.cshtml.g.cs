#pragma checksum "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6251ebfd047188554110988d03f6ae85578c504a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Packages__packages), @"mvc.1.0.view", @"/Views/Home/Components/Packages/_packages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6251ebfd047188554110988d03f6ae85578c504a", @"/Views/Home/Components/Packages/_packages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70fdaad658247010fb03120532e5c3760fcff647", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Packages__packages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<be.package>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("420"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("480"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image-HasTech"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "package", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
    <div class=""product-section section-padding-b"">
                    <!--== Start: Section Title ==-->
                    <div class=""section-title2 text-center mt-n2"">
                        <h6 class=""sub-title"">مورد محبوب</h6>
                        <h2 class=""title"">پکیج ها</h2>
                    </div>
                    <!--== End: Section Title ==-->

                    <div class=""row"">
                        <div class=""col-12 swiper-button-wrap"">
                            <div class=""swiper product-slider-container"">
                                <div class=""swiper-wrapper"">
                                        <!--== Start: Product Item ==-->
                                    <div class=""swiper-slide"">
");
#nullable restore
#line 18 "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml"
                                             foreach (var item in Model)
                                           {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""product-item"">
                                               
                                            <div class=""product-thumb"">
                                                <a class=""d-block"" href=""product-details.html"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6251ebfd047188554110988d03f6ae85578c504a6329", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1255, "~/assets/images/photos/", 1255, 23, true);
#nullable restore
#line 24 "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml"
AddHtmlAttributeValue("", 1278, item.pic, 1278, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </a>
                                                <div class=""product-action-wrap"">
                                                    <div class=""product-action"">
                                                        <button type=""button"" class=""product-action-btn action-btn-quick-view"" data-bs-toggle=""modal"" data-bs-target=""#action-QuickViewModal"">
                                                            <i class=""icon-magnifier""></i>
                                                        </button>
                                                        <button type=""button"" class=""product-action-btn action-btn-wishlist"" data-bs-toggle=""modal"" data-bs-target=""#action-WishlistModal"">
                                                            <i class=""icon-heart""></i>
                                                        </button>
                                                        <button type=""button"" class=""product-action-btn acti");
            WriteLiteral(@"on-btn-compare"" data-bs-toggle=""modal"" data-bs-target=""#action-CompareModal"">
                                                            <i class=""icon-refresh""></i>
                                                        </button>
                                                        <button type=""button"" class=""product-action-btn action-btn-cart"" data-bs-toggle=""modal"" data-bs-target=""#action-CartAddModal"">
                                                            <i class=""icon-bag""></i>
                                                        </button>
                                                    </div>
                                                </div>
                                                
                                            </div>
                                           <div class=""gallery-content"">
                                               <h4 class=""gallery-title"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6251ebfd047188554110988d03f6ae85578c504a10094", async() => {
                WriteLiteral("پکیج ");
#nullable restore
#line 45 "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml"
                                                                                                                                                         Write(item.title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml"
                                                                                                                            WriteLiteral(item.packageId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                               <p class=\"gallery-desc\">تعداد سوال: ");
#nullable restore
#line 46 "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml"
                                                                              Write(item.questions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                               <p class=\"gallery-desc\">قیمت: ");
#nullable restore
#line 47 "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml"
                                                                        Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</p>\r\n                                           </div>\r\n                                            </div>\r\n");
#nullable restore
#line 50 "F:\BabTeb\BabTeb\Views\Home\Components\Packages\_packages.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                        <!--== End: prPduct Item ==-->
                                    </div>

                                               
                                    </div>

                                </div>
                            </div>
                            <!--== Add Arrows ==-->
                            <div class=""swiper-button-st2 prev product-swiper-button-prev""><i class=""icofont-thin-left""></i></div>
                            <div class=""swiper-button-st2 next product-swiper-button-next""><i class=""icofont-thin-right""></i></div>
                        </div>
                   
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<be.package>> Html { get; private set; }
    }
}
#pragma warning restore 1591
