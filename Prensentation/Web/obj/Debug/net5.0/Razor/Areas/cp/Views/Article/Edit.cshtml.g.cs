#pragma checksum "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\Article\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9845c5a11fce60287df32f96110c31305f0542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_cp_Views_Article_Edit), @"mvc.1.0.view", @"/Areas/cp/Views/Article/Edit.cshtml")]
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
#line 1 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\_ViewImports.cshtml"
using CMS.Core.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9845c5a11fce60287df32f96110c31305f0542", @"/Areas/cp/Views/Article/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242a9934b67511a537801d734b0099ca48f6d598", @"/Areas/cp/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_cp_Views_Article_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Add Article</h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f9845c5a11fce60287df32f96110c31305f05423562", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 94, "\"", 111, 1);
#nullable restore
#line 7 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\Article\Edit.cshtml"
WriteAttributeValue("", 102, Model.Id, 102, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <div class=\"form-group\">\r\n        <label for=\"Title\">Tiêu đề</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"Title\" name=\"Title\" placeholder=\"Nhập tiêu đề\"");
                BeginWriteAttribute("value", " value=\"", 287, "\"", 307, 1);
#nullable restore
#line 10 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\Article\Edit.cshtml"
WriteAttributeValue("", 295, Model.Title, 295, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Description\">Mô tả</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"Description\" name=\"Description\" placeholder=\"Nhập mô tả\"");
                BeginWriteAttribute("value", " value=\"", 509, "\"", 535, 1);
#nullable restore
#line 14 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\Article\Edit.cshtml"
WriteAttributeValue("", 517, Model.Description, 517, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Description\">Thumb</label>\r\n        <input type=\"text\" class=\"form-control mb-2\" id=\"Thumb\" name=\"Thumb\" placeholder=\"Nhập thumb hình\"");
                BeginWriteAttribute("value", " value=\"", 735, "\"", 755, 1);
#nullable restore
#line 18 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\Article\Edit.cshtml"
WriteAttributeValue("", 743, Model.Thumb, 743, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"button\" class=\"btn btn-primary mb-2\" id=\"btnCheckImage\" onclick=\"CheckImage()\" value=\"Xem hình\">\r\n        <div class=\"d-block\">\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 925, "\"", 943, 1);
#nullable restore
#line 21 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\Article\Edit.cshtml"
WriteAttributeValue("", 931, Model.Thumb, 931, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""previewImageThumb"">
        </div>
    </div>
    <div class=""form-group"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""document-editor__toolbar""></div>
                <div id=""editor"">
                    ");
#nullable restore
#line 29 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Areas\cp\Views\Article\Edit.cshtml"
               Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <button type=\"button\" onclick=\"Update()\" class=\"btn btn-primary\">Lưu</button>\r\n");
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
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591