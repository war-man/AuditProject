#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18bae8bfec0bb6eab3c5e070600d626754f696e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\_ViewImports.cshtml"
using WebAppCoreNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\_ViewImports.cshtml"
using WebAppCoreNew.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
using WebModelCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
using WebAppCoreNew.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
using WebModelCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
using WebModelCore.CodeInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18bae8bfec0bb6eab3c5e070600d626754f696e3", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e466c9603bffd2dcf4666222604ba1a8bde42712", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RowGridModMaintainModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
  
    Layout = null;
    var fieldGrid = Model.Fields;
    var moduleInfoModel = Model.ModuleInfo;
    var codeInfos = (List<CodeInfoModel>)ViewBag.DataCombobox;
    var dataControl = (List<dynamic>)null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<tr>\r\n");
#nullable restore
#line 16 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
     foreach (var field1 in fieldGrid)
    {
        if (field1.HideWeb == "Y")
        {
            continue;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 561, "\"", 584, 1);
#nullable restore
#line 22 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
WriteAttributeValue("", 569, field1.FieldID, 569, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
#nullable restore
#line 23 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCore\Views\Home\HomePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RowGridModMaintainModel> Html { get; private set; }
    }
}
#pragma warning restore 1591