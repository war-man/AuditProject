#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa87dc661267d6792f643b8834ad5fe7929aadb"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAppCoreBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using WebAppCoreBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using WebAppCoreBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Blazored Modal Sample</h1>\r\n\r\n<hr class=\"mb-5\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    This is an example of using Blazored Modal in its most simplistic form.\r\n</p>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mb-4");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "class", "card-text");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "code");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddContent(13, 
#nullable restore
#line 16 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Counter.razor"
                  "Modal.Show<Confirm>(\"Welcome to Blazored Modal\", options);"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Counter.razor"
                  ShowModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddContent(22, "Show Modal");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Counter.razor"
       
    void ShowModal() => Modal.Show<Confirm>("Welcome to Blazored Modal");


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
    }
}
#pragma warning restore 1591