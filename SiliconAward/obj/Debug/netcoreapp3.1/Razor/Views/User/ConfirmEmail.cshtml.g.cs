#pragma checksum "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86abd41ae1a38459e9e062eb1b661cba872d544d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ConfirmEmail), @"mvc.1.0.view", @"/Views/User/ConfirmEmail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86abd41ae1a38459e9e062eb1b661cba872d544d", @"/Views/User/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990cfd4b813846f53921ebc411c41ea4f6172c95", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-submit", new global::Microsoft.AspNetCore.Html.HtmlString("profile.submitPhone()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("profile.formTelephone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-otp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
Write(await Component.InvokeAsync("NToastNotify"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abd41ae1a38459e9e062eb1b661cba872d544d5040", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 92, "\'", 157, 1);
#nullable restore
#line 6 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
WriteAttributeValue("", 99, Url.Content("~/lib/bootstrap/dist/css/bootstrap.min.css"), 99, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 189, "\'", 231, 1);
#nullable restore
#line 7 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
WriteAttributeValue("", 196, Url.Content("~/lib/opt/style.css"), 196, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

    <style>

        body {
            margin: 0;
            /* border: 1px solid #c1c1c1; */
        }

        div {
            margin: 0;
        }

        .margin-zero {
            margin: 0;
        }

        ::placeholder {
            /* Chrome, Firefox, Opera, Safari 10.1+ */
            color: #4014af !important;
            opacity: 0.5 !important;
        }

        :-ms-input-placeholder {
            /* Internet Explorer 10-11 */
            color: #4014af !important;
            opacity: 0.5 !important;
        }

        ::-ms-input-placeholder {
            /* Microsoft Edge */
            color: #4014af !important;
            opacity: 0.5 !important;
        }

        input[type=""radio""] {
            display: none;
        }

            input[type=""radio""] + label:before {
                content: """";
                /* create custom radiobutton appearance */
                display: inline-block;
                width: 25px;
          ");
                WriteLiteral(@"      height: 25px;
                padding: 3px;
                margin-right: 3px;
                /* background-color only for content */
                background-clip: content-box;
                border: 2px solid #bbbbbb;
                background-color: #e7e6e7;
                border-radius: 50%;
            }

        .form-group input {
            background-color: #e9e3f9;
            color: #2d0592;
            border-bottom: 1px solid #2d0592;
        }

        /* appearance for checked radiobutton */
        input[type=""radio""]:checked + label:before {
            background-color: #2d0592;
            border: 2px solid #2d0592;
        }

        /* optional styles, I'm using this for centering radiobuttons */
        label {
            display: flex;
            align-items: center;
        }

        #page-elements {
            width: -webkit-fill-available;
            height: -webkit-fill-available;
        }

        #image-logo {
            displa");
                WriteLiteral(@"y: block;
            text-align: center;
        }

        .steps {
            display: block;
            text-align: center;
            font-family: sans-serif;
            color: #2d0592;
        }

        .step-header {
            font-size: 49px;
            font-weight: normal;
            font-stretch: normal;
            font-style: normal;
            line-height: 1.88;
            letter-spacing: 2.45px;
            white-space: nowrap;
        }

        .step-text {
            font-size: 23px;
            font-weight: lighter;
            font-stretch: normal;
            font-style: normal;
            line-height: 0.8;
            letter-spacing: 0.43px;
            color: #2d0592;
        }

        .step-email {
            color: black;
        }

        .step-confirm {
            object-fit: contain;
            border-radius: 25px;
            box-shadow: 0 3px 6px 0 rgba(45, 5, 146, 0.16);
            background-image: linear-gradient(179deg,");
                WriteLiteral(@" #ff0075 6%, #2d0592 139%);
            color: white;
        }

        .step-button {
            display: block;
            width: 30%;
            margin: auto;
        }

        .step-confirm {
            width: 100%;
            height: 45px;
        }

        .step-button p {
            font-size: 17px;
            font-weight: normal;
            font-stretch: normal;
            font-style: normal;
            line-height: 2.7;
            letter-spacing: normal;
        }

        #step-counter {
            width: 32%;
            margin: auto;
            padding: 40px 0 50px 0;
            height: 120px;
        }

        #step1 {
            float: left;
        }

            #step1 span {
                position: relative;
                right: 45px;
                color: #2d0592;
            }

        #step2 {
            float: right;
            direction: rtl;
        }

            #step2 span {
                position: relative;
");
                WriteLiteral(@"                left: 8px;
            }

        #separator {
            border-bottom: 1px solid #a3a3a3;
            margin: 0px 33px;
            position: relative;
            top: 12px;
        }

        #step-two-form {
            width: 39%;
            margin: auto;
            padding: 30px 0 0 0;
        }

        #fullname-help {
            text-align: left;
            padding-left: 14px;
            font-size: 12px;
            position: relative;
            bottom: 5px;
        }

        #step-two-from form {
            height: 50%;
        }

            #step-two-from form .form-group {
                height: 15%;
            }


        /* Extra small devices (phones, 600px and down) */
        ");
                WriteLiteral("@media only screen and (max-width: 1000px) {\r\n            #step-two-form {\r\n                width: 52%;\r\n            }\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abd41ae1a38459e9e062eb1b661cba872d544d12104", async() => {
                WriteLiteral("\r\n\r\n    <div id=\"page-elements\">\r\n        <div id=\"image-logo\">\r\n            <img");
                BeginWriteAttribute("src", " src=\'", 5338, "\'", 5391, 1);
#nullable restore
#line 218 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
WriteAttributeValue("", 5344, Url.Content("~/img/output-onlinepngtools.png"), 5344, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" title=""Silicon Awards"" alt=""Silicon Awards"">
        </div>
        <div id=""stepper"">
            <div id=""step-counter"">
                <div id=""step1"">
                    <input type=""radio"" name=""radio1"" id=""radio1"" />
                    <label for=""radio1""></label>
                    <span>verification email</span>
                </div>
                <div id=""separator""></div>
                <div id=""step2"">
                    <input type=""radio"" name=""radio2"" id=""radio2"" />
                    <label for=""radio2""></label>
                    <span>profile</span>
                </div>

            </div>

            <div id=""step-one"" class=""steps"">
                <H1 class=""step-header"">
                    Let's confirm your email
                </H1>
                <span class=""step-text"">type in the code we sent to </span>
                <span class="" step-text step-email"">EMAIL@GMAIL.COM</span>


                <!-- partial:index.partial.html -->
         ");
                WriteLiteral("       <section id=\"wrapper\" ng-app=\"otp\">\r\n                    <div class=\"content\" ng-controller=\"otpCtrl\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abd41ae1a38459e9e062eb1b661cba872d544d14117", async() => {
                    WriteLiteral(@"
                            <div class=""row"">
                                <div class=""input-code"">
                                    <input type=""text"" id=""otp-number-input-1"" class=""otp-number-input"" maxlength=""1""
                                           ng-change=""myFunc(this)"" ng-model=""myValue1"" numbers-only>

                                    <input type=""text"" id=""otp-number-input-2"" class=""otp-number-input"" maxlength=""1""
                                           ng-change=""myFunc(this)"" ng-model=""myValue2"" numbers-only>

                                    <input type=""text"" id=""otp-number-input-3"" class=""otp-number-input"" maxlength=""1""
                                           ng-change=""myFunc(this)"" ng-model=""myValue3"" numbers-only>

                                    <input type=""text"" id=""otp-number-input-4"" class=""otp-number-input"" maxlength=""1""
                                           ng-change=""myFunc(this)"" ng-model=""myValue4"" numbers-only>

                     ");
                    WriteLiteral(@"               <input type=""text"" id=""otp-number-input-5"" class=""otp-number-input"" tabindex=""5""
                                           maxlength=""1"" ng-change=""myFunc(this)"" ng-model=""myValue5"" numbers-only>
                                    <input type=""text"" id=""otp-number-input-6"" class=""otp-number-input"" maxlength=""1""
                                           ng-change=""myFunc(this)"" ng-model=""myValue6"" numbers-only>
                                </div>
                                <input type=""hidden"" name=""otp-number"" id=""otp-number""");
                    BeginWriteAttribute("class", " class=\"", 8266, "\"", 8274, 0);
                    EndWriteAttribute();
                    WriteLiteral(" maxlength=\"6\">\r\n                            </div>\r\n\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("no-validate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </section>

                <div class=""step-button"">
                    <button id=""step-one-confirm"" class=""step-confirm next"" name=""next"" value=""Next""
                            type=""button"">
                        Confirm
                    </button>

                    <p>Didn't receive the code? Send again</p>
                </div>
            </div>

            <div id=""step-two"" class=""steps"">
                <H1 class=""step-header"">
                    Welcome <span>misaqh008</span>
                </H1>
                <span class=""step-text"">Complete your profile to take on the challenges </span>

                <div id=""step-two-form"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abd41ae1a38459e9e062eb1b661cba872d544d18729", async() => {
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""fullname"" aria-describedby=""emailHelp""
                                   placeholder=""Full name"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""phonenumber"" placeholder=""Phone number"">
");
                    WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""locatiom"" placeholder=""Locatiom"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""your-skill"" placeholder=""Your skill"">
                        </div>

                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                </div>
                <div class=""step-button"">
                    <button id=""step-two-confirm"" class=""step-confirm next"" name=""next"" value=""Next"" type=""button"">
                        Go to profile
                    </button>


                </div>
            </div>
        </div>


    </div>

    <script");
                BeginWriteAttribute("src", " src=\'", 10442, "\'", 10495, 1);
#nullable restore
#line 325 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
WriteAttributeValue("", 10448, Url.Content("~/lib/jquery/dist/jquery.min.js"), 10448, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 10519, "\'", 10581, 1);
#nullable restore
#line 326 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
WriteAttributeValue("", 10525, Url.Content("~/lib/bootstrap/dist/js/bootstrap.min.js"), 10525, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 10605, "\'", 10650, 1);
#nullable restore
#line 327 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
WriteAttributeValue("", 10611, Url.Content("~/lib/js/angular.min.js"), 10611, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 10674, "\'", 10715, 1);
#nullable restore
#line 328 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\User\ConfirmEmail.cshtml"
WriteAttributeValue("", 10680, Url.Content("~/lib/opt/script.js"), 10680, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>

    <script>
        $('label[for=""radio1""]').click();
        $('#step-two').hide();
$('#step2').click(false);

        //enableSteptwo();

        $('#step-one-confirm').click(function () {
            enableSteptwo();
        })
        function enableSteptwo() {
            $('#step-one').hide();
            $('#step-two').show();
            $(""#separator"").css({ ""border"": ""1px solid #2d0592"" })
            $(""label[for='radio2']"").click();
            $('#step-counter #step2 span').css({ ""color"": ""#2d0592"" })
        }



        $(function () {
            $(""#step-one-confirm"").click(function () {
                var code = $('#otp-number').val().toString();
                if (code.length == 6) {
                    $.ajax({
                        type: ""POST"",
                        url: ""/user/EmailVerification/"" + code,
                        data: null,
                        success: function (response) {
                        },
                ");
                WriteLiteral(@"        failure: function (response) {
                        },
                        error: function (response) {
                        }
                    });
                }
                else {
                }
            });
        });

    </script>

");
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