#pragma checksum "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Home\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8adc16946def568b6f73eb17cc080eed69cd9e1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
#line 1 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\_ViewImports.cshtml"
using SiliconAward;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\_ViewImports.cshtml"
using SiliconAward.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8adc16946def568b6f73eb17cc080eed69cd9e1d", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990cfd4b813846f53921ebc411c41ea4f6172c95", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8adc16946def568b6f73eb17cc080eed69cd9e1d3430", async() => {
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 46, "\'", 111, 1);
#nullable restore
#line 5 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 53, Url.Content("~/lib/bootstrap/dist/css/bootstrap.min.css"), 53, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <style>
        html {
            height: 100%;
            background-image: linear-gradient(to right, rgb(87, 5, 139), rgb(0, 5, 152));
        }

        body {
            height: 100%;
            background-repeat: no-repeat;
            background-image: linear-gradient(149deg, #b8057d 9%, #000598 78%);
        }

        .color-white {
            color: white !important;
        }

        body,
        div {
            margin: 0;
        }

        a {
            text-decoration: none !important;
        }

            a:hover {
                color: #ffffff !important;
            }



        #bc-page #img-bc-page {
            width: 100%;
        }

        #menu {
            display: inline-block;
            height: 200px;
            width: 100%;
            position: absolute;
            left: -3px;
            text-align: center;
        }

        #menu-items {
            padding: 0;
            display: flex;
            justi");
                WriteLiteral(@"fy-content: center;
            list-style: none;
            margin-top: 24px;
        }

            #menu-items li {
                white-space: nowrap;
                text-align: center;
                white-space: nowrap;
                margin: auto 0;
                width: auto;
                padding: 0 2%;
            }

                #menu-items li #silicon-logo {
                    width: 135px;
                }

        .like-orange {
            font-family: Cairo;
            font-size: 16px;
            font-weight: 600;
            font-stretch: normal;
            font-style: normal;
            line-height: 1.88;
            letter-spacing: 0.8px;
            text-align: left;
            position: relative;
            bottom: 6px;
        }

            .like-orange a {
                color: #f8dd82;
            }

        .main {
            position: absolute;
            bottom: 0;
            height: 80%;
            right: 50;
        ");
                WriteLiteral(@"}

        .content {
            background: white; 
            margin: auto;
            border-radius: 10px 10px 0 0;
            width: 90%;
            text-align: center;
            height: 100%;
        }
        .developer {
            text-align: center;
            padding: 5px 0 12px 0;
        }

            .developer img {
                max-width: 100%;
                height: auto;
            }

        .text {
            width: 60%;
            text-align: justify;
            color: #224dc2;
            font-size: 14px;
            margin: auto;
        }

        .userinfo {
            position: relative;
            /* bottom: 6px; */
        }

            .userinfo img {
                width: 40px;
                border-radius: 50%;
                border: 1px solid white;
                height: 40px;
            }

            .userinfo a {
                font-size: 18px;
                position: relative;
                top: 2px;
                WriteLiteral("\n            }\r\n\r\n        ");
                WriteLiteral("@media (max-width: 1200px) {\r\n            .text {\r\n                width: 90%;\r\n            }\r\n        }\r\n\r\n        ");
                WriteLiteral(@"@media (max-width: 880px) {
            html, body {
                background-image: initial;
            }
            #menu-items li {
                width: 19%;
            }
            .color-white {
                color: #cc7417 !important;
            }
        }


        ");
                WriteLiteral(@"@media (max-width: 767px) {


            #menu-items {
                display: none;
            }

            .text {
                width: 92%;
            }

            body {
                background-color: white;
                background-image: initial;
            }

            .content {
                width: 100%;
                border-radius: 0;
            }

            .main {
                position: initial;
            }
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8adc16946def568b6f73eb17cc080eed69cd9e1d9095", async() => {
                WriteLiteral("\r\n    <div id=\"bc-page\">\r\n        <div id=\"menu\">\r\n            <ul id=\"menu-items\">\r\n                <li class=\"userinfo like-orange\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 4306, "\"", 4346, 1);
#nullable restore
#line 191 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 4312, Url.Content("~/img/Group723.png"), 4312, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""user image"" title=""user image"">
                    <a href=""#"">misagh008</a>
                </li>
                <li class=""like-orange"">
                    <a href=""#"">Chalenges</a>
                </li>
                <li> <a href=""index""><img id=""silicon-logo""");
                BeginWriteAttribute("src", " src=\"", 4627, "\"", 4667, 1);
#nullable restore
#line 197 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 4633, Url.Content("~/img/Group723.png"), 4633, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""silicon logo"" title=""silicon logo""></a></li>
                <li class=""like-orange"">
                    <a class=""color-white"" href=""contactus""> Contact us</a>
                </li>
                <li class=""like-orange"">
                    <a href=""#"">About us</a>
                </li>
            </ul>
        </div>
        <div class=""main"">
            <div class=""content"">
                <div class=""developer"">
                    <img");
                BeginWriteAttribute("src", " src=\"", 5136, "\"", 5171, 1);
#nullable restore
#line 209 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 5142, Url.Content("~/img/dev.png"), 5142, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" title=""developer"" alt=""developer"">
                </div>
                <div class=""text"">
                    <p>
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                    </p>
                </div>
            </div>
        </div>

    </div>
    <script");
                BeginWriteAttribute("src", " src=\'", 6005, "\'", 6058, 1);
#nullable restore
#line 220 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 6011, Url.Content("~/lib/jquery/dist/jquery.min.js"), 6011, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 6082, "\'", 6144, 1);
#nullable restore
#line 221 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 6088, Url.Content("~/lib/bootstrap/dist/js/bootstrap.min.js"), 6088, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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