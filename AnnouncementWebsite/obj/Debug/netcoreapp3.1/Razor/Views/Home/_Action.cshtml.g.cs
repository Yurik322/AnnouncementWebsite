#pragma checksum "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "052a192ad755d6186a4b4b69e2dc13d7b77ddc86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Action), @"mvc.1.0.view", @"/Views/Home/_Action.cshtml")]
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
#line 1 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\_ViewImports.cshtml"
using AnnouncementWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\_ViewImports.cshtml"
using AnnouncementWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"052a192ad755d6186a4b4b69e2dc13d7b77ddc86", @"/Views/Home/_Action.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a6e230038eb2a9648cf0b847a699506d7f2bdc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Action : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnnouncementWebsite.ViewModels.AnnouncementActionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("actionForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal-content\">\r\n        <div class=\"modal-header\">\r\n            <h5 class=\"modal-title\">\r\n");
#nullable restore
#line 8 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
                 if (Model.Id > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>\r\n                        Edit Announcement\r\n                    </span>\r\n");
#nullable restore
#line 13 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>\r\n                        Create Announcement\r\n                    </span>\r\n");
#nullable restore
#line 19 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h5>\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n        <div class=\"modal-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "052a192ad755d6186a4b4b69e2dc13d7b77ddc865298", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 853, "\"", 870, 1);
#nullable restore
#line 27 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
WriteAttributeValue("", 861, Model.Id, 861, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"form-group\">\r\n                    <label>Title</label>\r\n                    <input class=\"form-control\" name=\"Title\" placeholder=\"Enter Announcement Title\"");
                BeginWriteAttribute("value", " value=\"", 1059, "\"", 1079, 1);
#nullable restore
#line 30 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
WriteAttributeValue("", 1067, Model.Title, 1067, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Description</label>\r\n                    <textarea class=\"form-control\" name=\"Description\" placeholder=\"Enter Announcement Description.\">");
#nullable restore
#line 34 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
                                                                                                               Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                </div>\r\n            ");
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

            <div class=""errorDiv"">

            </div>
        </div>
        <div class=""modal-footer"">
            <button id=""actionButton"" type=""button"" class=""btn btn-primary""><i class=""fas fa-save mr-1""></i> Save</button>
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""fas fa-times mr-1""></i> Close</button>
        </div>
    </div>
");
#nullable restore
#line 47 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(\"#actionButton\").click(function() {\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 52 "E:\MY PROGRAMS\Projects\C#\Nerdy\AnnouncementWebsite\AnnouncementWebsite\Views\Home\_Action.cshtml"
             Write(Url.Action("Action", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""post"",
            data: $(""#actionForm"").serialize()
        }).done(function (response) {
            if (response.Success = true) {
                location.reload();
            } else {
                $("".errorDiv"").html(response.Message);
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnnouncementWebsite.ViewModels.AnnouncementActionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
