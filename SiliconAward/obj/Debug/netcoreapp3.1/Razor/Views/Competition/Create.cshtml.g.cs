#pragma checksum "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74784066222cf5aa74caa313d97c306947c1eb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competition_Create), @"mvc.1.0.view", @"/Views/Competition/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74784066222cf5aa74caa313d97c306947c1eb1", @"/Views/Competition/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990cfd4b813846f53921ebc411c41ea4f6172c95", @"/Views/_ViewImports.cshtml")]
    public class Views_Competition_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiliconAward.DataAccess.ViewModels.Competition.CompetitionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleInputEmail1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
  
    ViewData["Title"] = "Create Competition";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 176, "\'", 233, 1);
#nullable restore
#line 7 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
WriteAttributeValue("", 183, Url.Content("~/kendo/kendo.bootstrap-v4.min.css"), 183, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n");
            }
            );
            WriteLiteral("<style>\r\n    label {\r\n        white-space: nowrap;\r\n    }\r\n\r\n    .k-readonly {\r\n        color: gray;\r\n    }\r\n</style>\r\n\r\n<script");
            BeginWriteAttribute("src", " src=\'", 372, "\'", 425, 1);
#nullable restore
#line 20 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
WriteAttributeValue("", 378, Url.Content("~/lib/jquery/dist/jquery.min.js"), 378, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n<script");
            BeginWriteAttribute("src", " src=\'", 445, "\'", 491, 1);
#nullable restore
#line 21 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
WriteAttributeValue("", 451, Url.Content("~/kendo/kendo.all.min.js"), 451, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n<script");
            BeginWriteAttribute("src", " src=\'", 511, "\'", 563, 1);
#nullable restore
#line 22 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
WriteAttributeValue("", 517, Url.Content("~/kendo/kendo.aspnetmvc.min.js"), 517, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74784066222cf5aa74caa313d97c306947c1eb19048", async() => {
                WriteLiteral("\r\n    <h4 class=\"form-header\">\r\n        Create Competition\r\n    </h4>\r\n    ");
#nullable restore
#line 27 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"form-group  col-xl-6 col-lg-6 col-md-6\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d74784066222cf5aa74caa313d97c306947c1eb19776", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 30 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group   col-xl-6 col-lg-6 col-md-6\">\r\n            <div class=\"form-group\">\r\n                <div class=\"demo-section k-content\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
                Write(Html.Kendo().DropDownList()
            .OptionLabel("Select reward...")
          .Name("reward")
          .DataTextField("Text")
          .DataValueField("Value")
          .DataSource(source =>
          {
              source.Read(read =>
              {
                  read.Action("GetRewards", "Competition");
              });
          })
          .HtmlAttributes(new { style = "width: 100%" })
    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Reward, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
            </div>

        </div>
    </div>


    <div class=""row"">
        <div class=""form-group  col-xl-6 col-lg-6 col-md-6"">
            <div class=""form-group"">
                <div class=""demo-section k-content"">
                    ");
#nullable restore
#line 63 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
                Write(Html.Kendo().DropDownList()
              .Name("skillGroups")
              .HtmlAttributes(new { style = "width:100%" })
              .OptionLabel("Select group...")
              .DataTextField("Text")
              .DataValueField("Value")
              .DataSource(source =>
              {
                  source.Read(read =>
                  {
                      read.Action("GetSkillGroups", "Competition");
                  });
              })
    );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group   col-xl-6 col-lg-6 col-md-6\">\r\n            <div class=\"form-group\">\r\n                <div class=\"demo-section k-content\">\r\n                    ");
#nullable restore
#line 84 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
                Write(Html.Kendo().DropDownList()
              .Name("skillField")
              .HtmlAttributes(new { style = "width:100%" })
              .OptionLabel("Select field...")
              .DataTextField("Text")
              .DataValueField("Value")
              .DataSource(source =>
              {
                  source.Read(read =>
                  {
                      read.Action("GetSkillFields", "Competition")
                          .Data("filterSkillField");
                  })
                  .ServerFiltering(true);
              })
              .Enable(false)
              .AutoBind(false)
              .CascadeFrom("skillGroups"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 102 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.SkillField, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74784066222cf5aa74caa313d97c306947c1eb115914", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 110 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
#nullable restore
#line 111 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"form-group col-lg-6\">\r\n            <label for=\"exampleInputEmail1\">Start Competition</label>\r\n            <div>\r\n                ");
#nullable restore
#line 120 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
            Write(Html.Kendo().DateTimePicker()
          .Name("startCompetition")
          .Value(DateTime.Today)
          .Max(DateTime.Today)
          .ParseFormats(new string[] { "MM/dd/yyyy" })
          .Events(e => e.Change("startChange"))
          .HtmlAttributes(new { style = "width:250px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group  col-lg-6\">\r\n            <label for=\"exampleInputEmail1\">End Competition</label>\r\n            <div>\r\n                ");
#nullable restore
#line 133 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
            Write(Html.Kendo().DateTimePicker()
          .Name("endCompetition")
          .Value(DateTime.Today)
          .Min(DateTime.Today)
          .ParseFormats(new string[] { "MM/dd/yyyy" })
          .Events(e => e.Change("endChange"))
          .HtmlAttributes(new { style = "width:250px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary form-submit\">Submit</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 5055, "\'", 5101, 1);
#nullable restore
#line 154 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
WriteAttributeValue("", 5061, Url.Content("~/kendo/kendo.all.min.js"), 5061, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 5125, "\'", 5177, 1);
#nullable restore
#line 155 "C:\Users\Ali Taheri\source\repos\BaseProject\SiliconAward\Views\Competition\Create.cshtml"
WriteAttributeValue("", 5131, Url.Content("~/kendo/kendo.aspnetmvc.min.js"), 5131, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>

    <script>
        function startChange() {
            var start = $(""#startCompetition"").data(""kendoDateTimePicker"");
            var end = $(""#endCompetition"").data(""kendoDateTimePicker"");
            var startDate = start.value();
            var endDate = end.value();

            if (startDate) {
                startDate = new Date(startDate);
                startDate.setDate(startDate.getDate());
                end.min(startDate);
            } else if (endDate) {
                start.max(new Date(endDate));
            } else {
                endDate = new Date();
                start.max(endDate);
                end.min(endDate);
            }
        }

        function endChange() {
            var start = $(""#startCompetition"").data(""kendoDateTimePicker"");
            var end = $(""#endCompetition"").data(""kendoDateTimePicker"");
            var endDate = end.value();
            var startDate = start.value();

            if (endDate) {
             ");
                WriteLiteral(@"   endDate = new Date(endDate);
                endDate.setDate(endDate.getDate());
                start.max(endDate);
            } else if (startDate) {
                end.min(new Date(startDate));
            } else {
                endDate = new Date();
                start.max(endDate);
                end.min(endDate);
            }
        }
        function filterSkillField() {
            return {
                skillGroups: $(""#skillGroups"").val()
            };
        }

     

        $(document).ready(function () {
            var skillGroups = $(""#skillGroups"").data(""kendoDropDownList""),
                skillFields = $(""#skillField"").data(""kendoDropDownList"");

            $(""#get"").click(function () {
                var skillGroupsInfo = ""\nCategory: { id: "" + skillGroups.value() + "", name: "" + skillGroups.text() + "" }"",
                    skillFieldsInfo = ""\nProduct: { id: "" + skillFields.value() + "", name: "" + skillFields.text() + "" }"";
                    a");
                WriteLiteral("lert(\"Order details:\\n\" + skillGroupsInfo + skillFieldsInfo);\r\n            });\r\n        });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiliconAward.DataAccess.ViewModels.Competition.CompetitionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
