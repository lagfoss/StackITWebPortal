#pragma checksum "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9620e2815643f26391358887b4ae3667ce6d3a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9620e2815643f26391358887b4ae3667ce6d3a8", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1878c7cc840afbfaeba89737d068e3aed5e674f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documents\Webudvikling\StackIT projekt\stackit\StackITWebPortal\StackITmvc\Views\Home\Contact.cshtml"
  Layout = "_homePage";

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section class=\"contact-informations\">\r\n        <div class=\"site-wrapper flex\">\r\n            <div class=\"contact-informations__wrapper\">\r\n\r\n                <h2 class=\"contact-informations__title\">Get in touch</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9620e2815643f26391358887b4ae3667ce6d3a84595", async() => {
                WriteLiteral(@"

                    <label class=""form-group__label"" for=""name"">Name </label>
                    <input class=""form-group__field"" id=""name"" type=""text"" placeholder=""Fill in your Name"" required>

                    <label class=""form-group__label"" for=""email"">Email </label>
                    <input class=""form-group__field"" id=""email"" type=""email"" placeholder=""Fill in your Email"" required>

                    <label class=""form-group__label"" for=""text"">Subject</label>
                    <input class=""form-group__field"" id=""Subject"" type=""url"" placeholder=""Fill in your Subject"" required>

                    <label class=""form-group__label"" for=""message"">Message</label>
                    <input class=""form-group__field"" id=""message"" type=""text"" placeholder=""Fill in your Message"" required>

                    <button class=""btn btn--wide"" type=""submit"">Send Message</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </div>
            <div class=""contact__wrapper"">
                <h2 class=""contact__title contact__title--dark"">Informations</h2>
                <p class=""contact__company contact__company--dark"">StackIT ApS</p>
                <p class=""contact__address contact__adress--dark"">Sivlandvaenget 3, 1</p>
                <p class=""contact__address contact__adress--dark"">5260 Odense S</p>
                <div>
                    <p class=""contact__phone contact__phone--dark"">+45 60 19 14 80</p>
                </div>
                <div>
                    <p class=""contact__email contact__email--dark"">info@stackit.eu</p>
                </div>

                <p class=""contact__vat contact__vat--dark"">VAT:DK40558195</p>
            </div>
        </div>

    </section>
    <!--Our member section-->
    <section class=""contact-members"">
        <div class=""site-wrapper"">
            <h2 class=""contact-members__title"">Our members</h2>
            <div class=""testcontact"">");
            WriteLiteral("\r\n                <div class=\"contact-members__wrapper\">\r\n                    <img class=\"contact-members__img\" src=\"../Image/pi1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2432, "\"", 2438, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p class=""contact-members__job"">Co-founder, CEO</p>
                    <p class=""contact-members__name"">Jens Fynbo</p>
                    <p class=""contact-members__phone"">+45 60 19 14 80</p>
                    <p class=""contact-members__email"">jf@stackit.eu</p>
                </div>
                <div class=""contact-members__wrapper"">
                    <img class=""contact-members__img"" src=""../Image/pi2.png""");
            BeginWriteAttribute("alt", " alt=\"", 2888, "\"", 2894, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p class=""contact-members__job"">CTO</p>
                    <p class=""contact-members__name"">Bjarne Eskildsen</p>
                    <p class=""contact-members__phone"">+45 21 41 23 55</p>
                    <p class=""contact-members__email"">be@stackit.eu</p>
                </div>
                <div class=""contact-members__wrapper"">
                    <img class=""contact-members__img"" src=""../Image/pic3.png""");
            BeginWriteAttribute("alt", " alt=\"", 3339, "\"", 3345, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p class=""contact-members__job"">Software developer</p>
                    <p class=""contact-members__name"">Mikkel Andersen</p>
                    <p class=""contact-members__email"">ma@stackit.eu</p>
                </div>
                <div class=""contact-members__wrapper"">
                    <img class=""contact-members__img"" src=""../Image/pic4.png""");
            BeginWriteAttribute("alt", " alt=\"", 3729, "\"", 3735, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p class=""contact-members__job"">CO-founder</p>
                    <p class=""contact-members__name"">Palle Hannemann</p>
                    <p class=""contact-members__phone"">+45 26 29 84 42</p>
                    <p class=""contact-members__email"">ph@hannemann-eng.com</p>
                </div>

                <div class=""contact-members__wrapper"">
                    <img class=""contact-members__img"" src=""../Image/pic5.png""");
            BeginWriteAttribute("alt", " alt=\"", 4195, "\"", 4201, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p class=""contact-members__job"">CO-founder</p>
                    <p class=""contact-members__name"">Carl Matzen</p>
                    <p class=""contact-members__phone"">+45 50 10 80 14</p>
                    <p class=""contact-members__email"">cm@stackit.eu</p>
                </div>
            </div>
        </div>

    </section>


    <!--Googlemap section-->
    <div class=""google-maps"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2265.393701612573!2d10.377464015887057!3d55.403483480461404!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x464cdff64be99313%3A0xaa101b9beac9ee2!2sUCL%20Erhvervsakademi%20og%20Professionsh%C3%B8jskole!5e0!3m2!1sen!2sus!4v1574847914284!5m2!1sen!2sus""
                frameborder=""0"" scrolling=""no"" style=""width:100%; height:100%"" marginwidth=""0"" marginheight=""0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 5075, "\"", 5093, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n    </div>\r\n\r\n</main>\r\n\r\n");
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
