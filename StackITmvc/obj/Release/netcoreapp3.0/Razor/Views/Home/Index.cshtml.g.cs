#pragma checksum "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4d48242a62c382c40f690b22c028969d2e1960e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d48242a62c382c40f690b22c028969d2e1960e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1878c7cc840afbfaeba89737d068e3aed5e674f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn intro__button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn services__btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Home\Index.cshtml"
  Layout = "_homePage";

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section class=""intro"">
        <div class=""site-wrapper flex"">
            <div class=""intro__wrapper-left"">
                <h1 class=""intro__title"">Welcome to StackIT</h1>
                <p class=""intro__text"">
                    An online solution for programming robots in chip making
                    manufacturing companies.
                    The programming is done off-site, which is made possible through it
                    developed hardware and software
                    The goal is to make it possible to program all types of robots and all types of
                    CNC machines
                </p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d48242a62c382c40f690b22c028969d2e1960e5814", async() => {
                WriteLiteral("About us");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"intro__wrapper-right\">\r\n                <img class=\"intro__image\" src=\"image/robotic.png\"");
            BeginWriteAttribute("alt", " alt=\"", 960, "\"", 966, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
    </section>

    <!--Services section-->
    <section class=""services-frontPage"">
        <div class=""site-wrapper"">
            <h2 class=""services__title"">Services</h2>
            <div class=""services-wrapper flex"">
                <div class=""services__hover"">
                    <i class=""fas fa-robot""></i>
                    <h2 class=""services-focusbox__title"">CNC-services</h2>
                    <p class=""services-focusbox__text"">
                        CNC machining, requires money and experience to work well.
                        Bypass those barriers with our smart solution.
                    </p>
                </div>
                <div class=""services__hover"">
                    <i class=""fas fa-robot""></i>
                    <h2 class=""services-focusbox__title"">Robot installation</h2>
                    <p class=""services-focusbox__text"">
                        Lorem ipsum dolor sit, amet consectetur adipisicing elit.
 ");
            WriteLiteral(@"                       Lorem ipsum dolor sit, amet consectetur.
                    </p>
                </div>
                <div class=""services__hover"">
                    <i class=""fas fa-robot""></i>
                    <h2 class=""services-focusbox__title"">Title</h2>
                    <p class=""services-focusbox__text"">
                        Lorem ipsum dolor sit, amet consectetur adipisicing elit.
                        Lorem ipsum dolor sit, amet consectetur
                    </p>
                </div>
            </div>
            <div class=""services-button-hover flex"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d48242a62c382c40f690b22c028969d2e1960e9260", async() => {
                WriteLiteral("All services");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </section>

    <!--Partner section-->
    <section class=""partner"">
        <div class=""site-wrapper"">
            <h3 class=""partner__title"">Our Partners</h3>
            <div class=""partner__imageWrapper flex autoplay"">
                <div><img class=""partner__img"" src=""Image/partner.png""");
            BeginWriteAttribute("alt", " alt=\"", 3045, "\"", 3051, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img class=\"partner__img\" src=\"Image/partner.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3131, "\"", 3137, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img class=\"partner__img\" src=\"Image/partner.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3217, "\"", 3223, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img class=\"partner__img\" src=\"Image/partner.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3303, "\"", 3309, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img class=\"partner__img\" src=\"Image/partner.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3389, "\"", 3395, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img class=\"partner__img\" src=\"Image/partner.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3475, "\"", 3481, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img class=\"partner__img\" src=\"Image/partner.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3561, "\"", 3567, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591