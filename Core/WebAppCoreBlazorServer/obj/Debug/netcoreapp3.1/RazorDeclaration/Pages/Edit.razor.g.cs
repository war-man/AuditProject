#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdfc1a9c971322974bd355e54ead687852951aa7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 14 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using WebModelCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using WebModelCore.CodeInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using WebModelCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using WebAppCoreBlazorServer.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using WebAppCoreBlazorServer.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using WebAppCoreBlazorServer.BUS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using WebCore.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Pages\Edit.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{modId}/{modSearchId}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{modId}/{modSearchId}/{fieldNameEdit}/{parram}/{pedit}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{modId}/{RowGridEdit}/{IsGridEdit}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModuleService moduleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDistributedCache distributedCache { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration iConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591