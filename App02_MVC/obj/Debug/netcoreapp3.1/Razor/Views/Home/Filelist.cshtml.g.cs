#pragma checksum "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f611b5d609d8e850556c54615cd286d331157f63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Filelist), @"mvc.1.0.view", @"/Views/Home/Filelist.cshtml")]
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
#line 1 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\_ViewImports.cshtml"
using App02_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\_ViewImports.cshtml"
using App02_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f611b5d609d8e850556c54615cd286d331157f63", @"/Views/Home/Filelist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54b123e76f4b219563e0c81738072c378d4f8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Filelist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
  
    ViewData["Title"] = "Filelist";
    //string curdir = Directory.GetCurrentDirectory();
    string dr = "E:\\ASPNET_Core";
    string[] files = Directory.GetFiles(dr);
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"alert alert-info\">File List</h2>\r\n\r\n");
            WriteLiteral(@"
<table class=""table table-responsive table-bordered table-hover"">
    <thead>
        <tr>
            <th>SL No.</th>
            <th>File Name</th>
            <th>Extension</th>
            <th>File Path</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
         foreach (var f in files)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
               Write(System.IO.Path.GetFileNameWithoutExtension(f));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
               Write(System.IO.Path.GetExtension(f));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
               Write(f);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App02_MVC\App02_MVC\Views\Home\Filelist.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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