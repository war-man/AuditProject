#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d8da04656b1c1c7e64a31e1bf7b23cc292c2f6c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebAppCoreBlazorServer.Shared
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
#line 3 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\MainLayout.razor"
using WebAppCoreBlazorServer.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\MainLayout.razor"
using WebAppCoreBlazorServer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\MainLayout.razor"
using WebAppCoreBlazorServer.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 356 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\MainLayout.razor"
       
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("Onload");
            await JSRuntime.InvokeVoidAsync("CallDatePicker");
        }
    }
    public void Logout()
    {
         ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut();
        NavigationManager.NavigateTo("");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
