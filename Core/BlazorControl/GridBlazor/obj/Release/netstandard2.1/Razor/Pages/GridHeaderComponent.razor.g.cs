#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e664069b452593ed92d9af2eb42757e8190ccf"
// <auto-generated/>
#pragma warning disable 1591
namespace GridBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
using GridShared.Sorting;

#line default
#line hidden
#nullable disable
    public partial class GridHeaderComponent<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "th");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 6 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
            _cssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 6 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                               _cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "grid-header-group");
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 8 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
         if (Column.HeaderCheckbox)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "grid-header-checkbox");
            __builder.AddMarkupContent(10, "              \n");
#nullable restore
#line 11 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                 if (_allChecked == null || _showAllChecked == false)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "class", "grid-header-checkbox-input");
            __builder.AddAttribute(14, "type", "checkbox");
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                         HeaderCheckboxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(16, "onclick", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    <span class=\"null-checkbox\"></span>\n");
#nullable restore
#line 15 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "checkbox");
            __builder.AddAttribute(21, "checked", 
#nullable restore
#line 18 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                     _allChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                             HeaderCheckboxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(23, "onclick", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#nullable restore
#line 19 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 21 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
        }
        else if (Column.FilterEnabled)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "grid-filter");
            __builder.AddAttribute(30, "data-type", 
#nullable restore
#line 24 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                 Column.FilterWidgetTypeName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "data-name", 
#nullable restore
#line 24 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                          Column.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "data-widgetdata", 
#nullable restore
#line 24 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                         JsonSerializer.Serialize(Column.FilterWidgetData)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "data-filterdata", 
#nullable restore
#line 24 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                                                                                              JsonSerializer.Serialize(_filterSettings)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "data-url", 
#nullable restore
#line 24 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                                                                                                                                                    _url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "data-clearinitfilter", 
#nullable restore
#line 24 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                                                                                                                                                                                 _clearInitFilter.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", 
#nullable restore
#line 25 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                              _cssFilterClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "title", 
#nullable restore
#line 25 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                       Strings.FilterButtonTooltipText

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                  FilterIconClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(41, "onclick", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                ");
            __builder.AddContent(43, 
#nullable restore
#line 26 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                 FilterWidgetRender

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 28 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
         if (Column.ParentGrid.ExtSortingEnabled)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "grid-extsort-draggable" + " " + (
#nullable restore
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                _cssSortingClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "draggable", "true");
            __builder.AddAttribute(50, "data-column", 
#nullable restore
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                 Column.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                            () => HandleDragStart()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                                                                   DisplayTooltip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                                                                                                HideTooltip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\n");
#nullable restore
#line 32 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                 if (Column.SortEnabled)
                {
                    if (Column.IsSorted)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                        ");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "href", "javascript:void(0);");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                TitleButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "data-column", 
#nullable restore
#line 36 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                  Column.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(60, "data-sorted", 
#nullable restore
#line 36 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                              Column.Direction == GridSortDirection.Ascending ? "asc" : "desc"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, 
#nullable restore
#line 36 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                                                                                                  Column.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n");
#nullable restore
#line 37 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                        ");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "href", "javascript:void(0);");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                TitleButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "data-column", 
#nullable restore
#line 40 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                  Column.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, 
#nullable restore
#line 40 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                                                Column.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n");
#nullable restore
#line 41 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                    ");
            __builder.OpenElement(71, "span");
            __builder.AddAttribute(72, "data-column", 
#nullable restore
#line 45 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                        Column.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, 
#nullable restore
#line 45 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                      Column.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n");
#nullable restore
#line 46 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                 if (Column.IsSorted)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "                    <span class=\"grid-sort-arrow\"></span>\n");
#nullable restore
#line 50 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n");
#nullable restore
#line 52 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", 
#nullable restore
#line 55 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                         _cssSortingClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(81, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                         DisplayTooltip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                                      HideTooltip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(83, "\n");
#nullable restore
#line 56 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                 if (Column.SortEnabled)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                    ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                      TitleButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "type", "button");
            __builder.AddContent(88, 
#nullable restore
#line 58 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                         Column.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n");
#nullable restore
#line 59 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                    ");
            __builder.OpenElement(91, "span");
            __builder.AddContent(92, 
#nullable restore
#line 62 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                           Column.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\n");
#nullable restore
#line 63 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                 if (Column.IsSorted)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "                    <span class=\"grid-sort-arrow\"></span>\n");
#nullable restore
#line 67 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n");
#nullable restore
#line 69 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n");
#nullable restore
#line 71 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
     if (!string.IsNullOrWhiteSpace(Column.TooltipValue))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "        ");
            __builder.OpenComponent<GridBlazor.Pages.HeaderTooltipComponent>(100);
            __builder.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                        Column.TooltipValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 73 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
                                                                       _isTooltipVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\n");
#nullable restore
#line 74 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridHeaderComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591