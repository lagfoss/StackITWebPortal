#pragma checksum "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d6733f1ddc5e01789435b92ceb42eefff3c6ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
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
#line 1 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\_ViewImports.cshtml"
using StackITmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\_ViewImports.cshtml"
using StackITmvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d6733f1ddc5e01789435b92ceb42eefff3c6ca", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1878c7cc840afbfaeba89737d068e3aed5e674f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StackITmvc.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn--primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>
<hr />
<h4>Customer</h4>
        
        <section class=""detail-information"">
            
                <table class=""detail-information__wrapper"">          
                        <tr>
                            <th>
                                ");
#nullable restore
#line 16 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>                  \r\n                            <td>\r\n                                ");
#nullable restore
#line 19 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 24 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.VAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 27 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.VAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 32 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 35 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 40 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.StreetNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 43 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.StreetNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 48 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 56 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 64 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 67 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 72 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 75 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 80 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                </table>\r\n                \r\n        </section>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56d6733f1ddc5e01789435b92ceb42eefff3c6ca13074", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Customers\Details.cshtml"
                                                        WriteLiteral(Model.CustomerId);

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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56d6733f1ddc5e01789435b92ceb42eefff3c6ca15372", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StackITmvc.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591