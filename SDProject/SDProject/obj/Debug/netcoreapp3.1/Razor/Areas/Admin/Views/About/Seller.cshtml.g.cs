#pragma checksum "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\About\Seller.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5145d7c7efe721d870f913eb82e4523e5cd70e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_About_Seller), @"mvc.1.0.view", @"/Areas/Admin/Views/About/Seller.cshtml")]
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
#line 1 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\_ViewImports.cshtml"
using SDProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\About\Seller.cshtml"
using SDProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5145d7c7efe721d870f913eb82e4523e5cd70e31", @"/Areas/Admin/Views/About/Seller.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce963b906dca970ff4fabe98b02f2bb6de4fb1e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_About_Seller : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\About\Seller.cshtml"
  
    ViewData["Title"] = "Seller";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<br />
<br />

    <h4 class=""text-info"">SELLER LIST</h4>



    <br />
    <div class=""p-4 border rounded box-shadow"">
        <table class=""table table-striped border  box-shadow"" id=""myTable"">
            <thead>
                <tr class=""bg-info text-light"">
                    <th>
                        Name
                    </th>
                    <th>
                        Email
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\About\Seller.cshtml"
                 foreach (var item in Model.userLists)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\About\Seller.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\About\Seller.cshtml"
                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Admin\Views\About\Seller.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n          \r\n         \r\n        </table>\r\n\r\n    </div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').DataTable();\r\n        });\r\n\r\n\r\n\r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591