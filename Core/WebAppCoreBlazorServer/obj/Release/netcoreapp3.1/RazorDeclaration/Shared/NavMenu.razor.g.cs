#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10053b94fd35a884a4f1012ffb47db6186a788c1"
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
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using WebCore.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using WebModelCore.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using WebModelCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using WebAppCoreBlazorServer.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using WebAppCoreBlazorServer.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using WebAppCoreBlazorServer.Common.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "G:\ATuanLM\AuditProject\Audit\Program\Core\WebAppCoreBlazorServer\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    private List<MenuModel> ListAllMenu { get; set; }
    private List<LanguageInfo> Languages { get; set; }
    protected override async Task OnInitializedAsync()
    {
        ListAllMenu = await LoadMenu();
    }
    private async Task<List<MenuModel>> LoadMenu()
    {
        var menus = new List<MenuModel>();
        int userId = int.Parse("0");
        var dataMenu = await LoadDataMenu(userId);
        if (dataMenu != null)
        {
            var leve0 = dataMenu.Where(x => x.OwnerMenuID == "000000");
            foreach (var item in leve0)
            {
                var menuRoot = new MenuModel
                {
                    Menu = item
                };
                var menuChild = dataMenu.Where(x => x.OwnerMenuID == item.MenuID);
                if (menuChild.Any())
                {
                    menuRoot.MenuChild.AddRange(menuChild.Select(x => new MenuModel { Menu = x }).ToList());
                }
                menus.Add(menuRoot);
            }
        }

        Languages = await LoadAllIcon();
        return menus;
    }

    private async Task<List<MenuItemInfo>> LoadDataMenu(int userId)
    {
        string key = ECacheKey.Menu.ToString();
        var menus = await menuService.GetAllMenu(userId);
        return menus;
    }

    private async Task<List<LanguageInfo>> LoadAllIcon()
    {
        string key = ECacheKey.AllIcon.ToString();
        var cachedData = distributedCache.GetString(key);
        if (cachedData != null)
        {
            var menus = JsonConvert.DeserializeObject<List<LanguageInfo>>(cachedData);
            return menus;
        }
        else
        {
            var menus = await languageService.GetAllIcon();
            RedisUtils.SetCacheData(distributedCache, iConfiguration, menus, key);
            return menus;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDistributedCache distributedCache { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILanguageService languageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration iConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMenuService menuService { get; set; }
    }
}
#pragma warning restore 1591