#pragma checksum "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Views\Shared\_footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73cb682927c265f9b7a7c95c4251d3aeeca408e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__footer), @"mvc.1.0.view", @"/Views/Shared/_footer.cshtml")]
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
#line 1 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Views\_ViewImports.cshtml"
using CMS.Core.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73cb682927c265f9b7a7c95c4251d3aeeca408e6", @"/Views/Shared/_footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70105755930da41d04ed60076eb27dcdf312b8e3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside class=""aside footer-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 holder"">
                <div class=""col"">
                    <!-- logo of the page -->
                    <div class=""logo"">
                        <a href=""#"">
                            <img src=""images/logo2.png"" alt=""dot"">
                        </a>
                    </div>
                    <!-- logo of the page end -->
                    <p>
                        Copyright ");
#nullable restore
#line 14 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Views\Shared\_footer.cshtml"
                             Write(Html.Raw("@"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "E:\Workspace\Repo\Github\SchoolProject\Prensentation\Web\Views\Shared\_footer.cshtml"
                                            Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <!-- Social Network of the page -->\r\n");
            WriteLiteral("                    <!-- Social Network of the page -->\r\n                </div>\r\n                <!-- footer nav of the page -->\r\n");
            WriteLiteral("                <!-- footer nav of the page end -->\r\n                <!-- Widget holder of the page -->\r\n");
            WriteLiteral("                <!-- Widget holder of the page end -->\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591