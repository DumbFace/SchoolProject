#pragma checksum "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c19d9317992dcff4ec1ccca6c1de1785ad951384"
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
#line 1 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\_ViewImports.cshtml"
using SchoolProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\_ViewImports.cshtml"
using SchoolProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\_ViewImports.cshtml"
using CMS.Core.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19d9317992dcff4ec1ccca6c1de1785ad951384", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db6988a5bf7142cbedc35da21ed5fd8cea5036c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <input type=\"text\" id=\"Name\" name=\"Name\" class=\"form form-control\"");
            BeginWriteAttribute("value", " value=\"", 195, "\"", 203, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""nhập tên"">
        <button type=""button"" class=""btn btn-success"" onclick=""Create()"">Create New</button>
    </div>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
         if (Model.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"btn btn-success mr-2 me-2\" data-itemid=\"");
#nullable restore
#line 32 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                            onclick=\"Delete(event)\">Delete</button>\r\n                        <button type=\"button\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#modelId\"");
            BeginWriteAttribute("onclick", "\r\n                            onclick=\"", 1025, "\"", 1084, 3);
            WriteAttributeValue("", 1064, "GetStudent(", 1064, 11, true);
#nullable restore
#line 35 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 1075, item.Id, 1075, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1083, ")", 1083, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Update</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\WorkSpace\repo\Github\SchoolProject\Prensentation\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<!-- Modal -->\r\n<div class=\"modal fade\" id=\"modelId\">\r\n\r\n    <input type=\"hidden\" id=\"IdUpdate\"");
            BeginWriteAttribute("value", " value=\"", 1300, "\"", 1308, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Update</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <label");
            BeginWriteAttribute("for", " for=\"", 1752, "\"", 1758, 0);
            EndWriteAttribute();
            WriteLiteral(">Name: </label>\r\n                <input type=\"text\" class=\"form-control\" name=\"NameUpdate\" id=\"NameUpdate\"");
            BeginWriteAttribute("value", " value=\"", 1865, "\"", 1873, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""Save()"">Save</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function GetStudent(id) {
            $.ajax({
                type: ""GET"",
                url: `api/student/${id}`,
                success: function (data) {
                    if (data.result == ""OK"") {
                        $(""#NameUpdate"").val(data.data.name);
                        $(""#IdUpdate"").val(data.data.id)
                    }
                }
            })
        }

        function Save() {
            var id = $(""#IdUpdate"").val()
            var name = $(""#NameUpdate"").val();
            var student = new Object();
            student.Name = name;
            $.ajax({
                type: ""PUT"",
                url: `api/student/${id}`,
                data: JSON.stringify(student),
                contentType: ""application/json; charset=utf-8"",
                success: function (data) {
                    document.location = ""/"";
                }
            })
        }

        function Create() {
            var name = $(""");
                WriteLiteral(@"#Name"").val();
            var student = new Object();
            student.Name = name;

            $.ajax({
                type: ""POST"",
                url: ""api/student/"",
                data: JSON.stringify(student),
                contentType: ""application/json; charset=utf-8"",
                success: function (result) {
                    if (result == ""Saved!"") {
                        document.location = ""/"";
                    }
                }
            })
        }

        function Delete(e) {
            var id = $(e.currentTarget).data(""itemid"");

            $.ajax({
                type: ""DELETE"",
                url: `api/student/${id}`,
                success: function (result) {
                    if (result == ""OK"") {
                        document.location = ""/"";
                    }
                }
            })
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
