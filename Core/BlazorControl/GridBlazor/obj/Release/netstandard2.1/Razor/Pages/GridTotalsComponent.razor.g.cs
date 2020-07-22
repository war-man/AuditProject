#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9bb4e2366e6712abfac17340796786dc4f073f0"
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
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
using GridShared.Columns;

#line default
#line hidden
#nullable disable
    public partial class GridTotalsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
 if (Grid != null && !Grid.ComponentOptions.RenderRowsOnly)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<tr class=\"grid-row\"><td class=\"grid-cell\" style=\"height:25px;border:none;background-color:white\"></td></tr>\n");
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
    var firstColumn = (ITotalsColumn)Grid.Columns.FirstOrDefault();
    if (Grid.IsSumEnabled)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "tr");
            __builder.AddAttribute(4, "class", "grid-totals-row");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 11 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.SubGridKeys != null && Grid.SubGridKeys.Length > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "                <td class=\"grid-cell\" data-name style=\"width:36.5px;\"></td>\n");
#nullable restore
#line 14 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.ReadEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 18 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.UpdateEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 22 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.DeleteEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 26 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (firstColumn != null
                && (firstColumn.IsSumEnabled || firstColumn.IsAverageEnabled
                || firstColumn.IsMaxEnabled || firstColumn.IsMinEnabled))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "class", "grid-cell");
            __builder.AddAttribute(13, "style", "width:90px;");
            __builder.OpenElement(14, "b");
            __builder.AddContent(15, 
#nullable restore
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                              Strings.Sum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
#nullable restore
#line 32 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             for (int i = 0; i < Grid.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Grid.Columns.ElementAt(i);
                string cssStyles;
                if (((IGridColumn)column).Hidden)
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString() + " " + TdStyle;
                else
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString();
                if (!string.IsNullOrWhiteSpace(((IGridColumn)column).Width))
                    cssStyles = string.Concat(cssStyles, " width:", ((IGridColumn)column).Width, ";").Trim();
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                    ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "class", "grid-cell");
            __builder.AddAttribute(20, "style", 
#nullable restore
#line 46 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                  cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(21, "b");
            __builder.AddContent(22, 
#nullable restore
#line 46 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                 Strings.Sum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#nullable restore
#line 47 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                }
                else
                {
                    if (column.IsSumEnabled)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                        ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "class", "grid-cell");
            __builder.AddAttribute(27, "style", 
#nullable restore
#line 52 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(28, "b");
            __builder.AddContent(29, 
#nullable restore
#line 52 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                     column.SumString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 53 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                        ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "grid-cell");
            __builder.AddAttribute(34, "style", 
#nullable restore
#line 56 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 57 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                }

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 62 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
    }
    if (Grid.IsAverageEnabled)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.OpenElement(39, "tr");
            __builder.AddAttribute(40, "class", "grid-totals-row");
            __builder.AddMarkupContent(41, "\n");
#nullable restore
#line 66 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.SubGridKeys != null && Grid.SubGridKeys.Length > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "                <td class=\"grid-cell\" data-name style=\"width:36.5px;\"></td>\n");
#nullable restore
#line 69 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.ReadEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 73 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.UpdateEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 77 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.DeleteEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 81 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (firstColumn != null
                && (firstColumn.IsSumEnabled || firstColumn.IsAverageEnabled
                || firstColumn.IsMaxEnabled || firstColumn.IsMinEnabled))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "class", "grid-cell");
            __builder.AddAttribute(49, "style", "width:90px;");
            __builder.OpenElement(50, "b");
            __builder.AddContent(51, 
#nullable restore
#line 86 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                              Strings.Average

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
#nullable restore
#line 87 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             for (int i = 0; i < Grid.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Grid.Columns.ElementAt(i);
                string cssStyles;
                if (((IGridColumn)column).Hidden)
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString() + " " + TdStyle;
                else
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString();
                if (!string.IsNullOrWhiteSpace(((IGridColumn)column).Width))
                    cssStyles = string.Concat(cssStyles, " width:", ((IGridColumn)column).Width, ";").Trim();
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                    ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "class", "grid-cell");
            __builder.AddAttribute(56, "style", 
#nullable restore
#line 101 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                  cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(57, "b");
            __builder.AddContent(58, 
#nullable restore
#line 101 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                 Strings.Average

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n");
#nullable restore
#line 102 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                }
                else
                {
                    if (column.IsAverageEnabled)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                        ");
            __builder.OpenElement(61, "td");
            __builder.AddAttribute(62, "class", "grid-cell");
            __builder.AddAttribute(63, "style", 
#nullable restore
#line 107 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(64, "b");
            __builder.AddContent(65, 
#nullable restore
#line 107 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                     column.AverageString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n");
#nullable restore
#line 108 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                        ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "class", "grid-cell");
            __builder.AddAttribute(70, "style", 
#nullable restore
#line 111 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n");
#nullable restore
#line 112 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n");
#nullable restore
#line 116 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
    }
    if (Grid.IsMaxEnabled)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "        ");
            __builder.OpenElement(75, "tr");
            __builder.AddAttribute(76, "class", "grid-totals-row");
            __builder.AddMarkupContent(77, "\n");
#nullable restore
#line 120 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.SubGridKeys != null && Grid.SubGridKeys.Length > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "                <td class=\"grid-cell\" data-name style=\"width:36.5px;\"></td>\n");
#nullable restore
#line 123 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.ReadEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 127 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.UpdateEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 131 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.DeleteEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 135 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (firstColumn != null
                && (firstColumn.IsSumEnabled || firstColumn.IsAverageEnabled
                || firstColumn.IsMaxEnabled || firstColumn.IsMinEnabled))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "class", "grid-cell");
            __builder.AddAttribute(85, "style", "width:90px;");
            __builder.OpenElement(86, "b");
            __builder.AddContent(87, 
#nullable restore
#line 140 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                              Strings.Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n");
#nullable restore
#line 141 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             for (int i = 0; i < Grid.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Grid.Columns.ElementAt(i);
                string cssStyles;
                if (((IGridColumn)column).Hidden)
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString() + " " + TdStyle;
                else
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString();
                if (!string.IsNullOrWhiteSpace(((IGridColumn)column).Width))
                    cssStyles = string.Concat(cssStyles, " width:", ((IGridColumn)column).Width, ";").Trim();
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                    ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "class", "grid-cell");
            __builder.AddAttribute(92, "style", 
#nullable restore
#line 155 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                  cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(93, "b");
            __builder.AddContent(94, 
#nullable restore
#line 155 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                 Strings.Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n");
#nullable restore
#line 156 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                }
                else
                {
                    if (column.IsMaxEnabled)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                        ");
            __builder.OpenElement(97, "td");
            __builder.AddAttribute(98, "class", "grid-cell");
            __builder.AddAttribute(99, "style", 
#nullable restore
#line 161 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(100, "b");
            __builder.AddContent(101, 
#nullable restore
#line 161 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                     column.MaxString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\n");
#nullable restore
#line 162 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                        ");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "class", "grid-cell");
            __builder.AddAttribute(106, "style", 
#nullable restore
#line 165 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n");
#nullable restore
#line 166 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n");
#nullable restore
#line 170 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
    }
    if (Grid.IsMinEnabled)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "        ");
            __builder.OpenElement(111, "tr");
            __builder.AddAttribute(112, "class", "grid-totals-row");
            __builder.AddMarkupContent(113, "\n");
#nullable restore
#line 174 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.SubGridKeys != null && Grid.SubGridKeys.Length > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "                <td class=\"grid-cell\" data-name style=\"width:36.5px;\"></td>\n");
#nullable restore
#line 177 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.ReadEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 181 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 182 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.UpdateEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(116, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 185 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (Grid.DeleteEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(117, "                <td class=\"grid-cell\" data-name style=\"width:35px;\"></td>\n");
#nullable restore
#line 189 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             if (firstColumn != null
                && (firstColumn.IsSumEnabled || firstColumn.IsAverageEnabled
                || firstColumn.IsMaxEnabled || firstColumn.IsMinEnabled))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "                ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "class", "grid-cell");
            __builder.AddAttribute(121, "style", "width:90px;");
            __builder.OpenElement(122, "b");
            __builder.AddContent(123, 
#nullable restore
#line 194 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                              Strings.Min

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\n");
#nullable restore
#line 195 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
             for (int i = 0; i < Grid.Columns.Count(); i++)
            {
                var column = (ITotalsColumn)Grid.Columns.ElementAt(i);
                string cssStyles;
                if (((IGridColumn)column).Hidden)
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString() + " " + TdStyle;
                else
                    cssStyles = ((GridStyledColumn)column).GetCssStylesString();
                if (!string.IsNullOrWhiteSpace(((IGridColumn)column).Width))
                    cssStyles = string.Concat(cssStyles, " width:", ((IGridColumn)column).Width, ";").Trim();
                if (i == 0 && !column.IsSumEnabled && !column.IsAverageEnabled
                   && !column.IsMaxEnabled && !column.IsMinEnabled)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                    ");
            __builder.OpenElement(126, "td");
            __builder.AddAttribute(127, "class", "grid-cell");
            __builder.AddAttribute(128, "style", 
#nullable restore
#line 209 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                  cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(129, "b");
            __builder.AddContent(130, 
#nullable restore
#line 209 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                 Strings.Min

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\n");
#nullable restore
#line 210 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                }
                else
                {
                    if (column.IsMinEnabled)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, "                        ");
            __builder.OpenElement(133, "td");
            __builder.AddAttribute(134, "class", "grid-cell");
            __builder.AddAttribute(135, "style", 
#nullable restore
#line 215 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(136, "b");
            __builder.AddContent(137, 
#nullable restore
#line 215 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                                     column.MinString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\n");
#nullable restore
#line 216 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "                        ");
            __builder.OpenElement(140, "td");
            __builder.AddAttribute(141, "class", "grid-cell");
            __builder.AddAttribute(142, "style", 
#nullable restore
#line 219 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                                                      cssStyles

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\n");
#nullable restore
#line 220 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
                    }
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(144, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\n");
#nullable restore
#line 224 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\GridTotalsComponent.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591