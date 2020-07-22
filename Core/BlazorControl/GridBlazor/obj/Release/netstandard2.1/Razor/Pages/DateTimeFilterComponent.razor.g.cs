#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d755cf4f69801c7d169184ca173877e4c40ca1c"
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
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
    public partial class DateTimeFilterComponent<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dropdown dropdown-menu grid-dropdown opened");
            __builder.AddAttribute(3, "style", "display:block;" + (
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                    _offset > 0 ? "margin-left:-" + _offset.ToString() + "px;" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                                                                                                                      FilterKeyup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(5, "onclick", true);
            __builder.AddEventStopPropagationAttribute(6, "onkeyup", true);
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                                                                                            dateTimeFilter = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "grid-dropdown-arrow");
            __builder.AddAttribute(11, "style", 
#nullable restore
#line 8 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                  _offset > 0 ? "margin-left:" + _offset.ToString() + "px" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "grid-dropdown-inner");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "grid-popup-widget");
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "grid-filter-body");
            __builder.AddMarkupContent(21, "\n");
#nullable restore
#line 12 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                     for (int i = 0; i < _filters.Count(); i++)
                    {
                        int j = i;
                        if (j == 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group row");
            __builder.AddMarkupContent(25, "\n                                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-md-4 col-md-offset-4 offset-md-4");
            __builder.AddMarkupContent(28, "\n                                    ");
            __builder.OpenElement(29, "select");
            __builder.AddAttribute(30, "class", "grid-filter-cond form-control");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                         _condition

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _condition = __value, _condition));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(33, "\n                                        ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "1");
            __builder.AddContent(36, 
#nullable restore
#line 20 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                           Strings.And

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                                        ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "2");
            __builder.AddContent(40, 
#nullable restore
#line 21 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                           Strings.Or

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#nullable restore
#line 25 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                        }
                        else if (j > 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group row");
            __builder.AddMarkupContent(48, "\n                                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-md-4 col-md-offset-4 offset-md-4");
            __builder.AddMarkupContent(51, "\n                                    ");
            __builder.OpenElement(52, "select");
            __builder.AddAttribute(53, "class", "grid-filter-cond form-control");
            __builder.AddAttribute(54, "disabled", "disabled");
            __builder.AddAttribute(55, "value", 
#nullable restore
#line 30 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                                              _condition

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, "\n                                        ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "1");
            __builder.AddContent(59, 
#nullable restore
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                           Strings.And

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                                        ");
            __builder.OpenElement(61, "option");
            __builder.AddAttribute(62, "value", "2");
            __builder.AddContent(63, 
#nullable restore
#line 32 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                           Strings.Or

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n");
#nullable restore
#line 36 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "                        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-group row");
            __builder.AddMarkupContent(71, "\n                            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-md-6");
            __builder.AddMarkupContent(74, "\n");
#nullable restore
#line 39 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                 if (j == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                                    ");
            __builder.OpenElement(76, "label");
            __builder.AddAttribute(77, "class", "control-label");
            __builder.OpenElement(78, "b");
            __builder.AddContent(79, 
#nullable restore
#line 41 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                     Strings.FilterTypeLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(80, ":");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                                    ");
            __builder.OpenElement(82, "div");
            __builder.AddMarkupContent(83, "\n                                        ");
            __builder.OpenElement(84, "select");
            __builder.AddAttribute(85, "class", "grid-filter-type form-control");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                                                _filters[j].Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Type = __value, _filters[j].Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(88, (__value) => {
#nullable restore
#line 43 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                      firstSelect = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(89, "\n                                            ");
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", "1");
            __builder.AddContent(92, 
#nullable restore
#line 44 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.Equal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\n                                            ");
            __builder.OpenElement(94, "option");
            __builder.AddAttribute(95, "value", "10");
            __builder.AddContent(96, 
#nullable restore
#line 45 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                Strings.NotEqual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n                                            ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", "5");
            __builder.AddContent(100, 
#nullable restore
#line 46 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.GreaterThan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n                                            ");
            __builder.OpenElement(102, "option");
            __builder.AddAttribute(103, "value", "6");
            __builder.AddContent(104, 
#nullable restore
#line 47 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.LessThan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\n                                            ");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value", "7");
            __builder.AddContent(108, 
#nullable restore
#line 48 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.GreaterThanOrEquals

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n                                            ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "8");
            __builder.AddContent(112, 
#nullable restore
#line 49 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.LessThanOrEquals

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\n");
#nullable restore
#line 50 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                             if (GridHeaderComponent.Column.Filter.IsNullable)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                                                ");
            __builder.OpenElement(115, "option");
            __builder.AddAttribute(116, "value", "11");
            __builder.AddContent(117, 
#nullable restore
#line 52 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                    Strings.IsNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n                                                ");
            __builder.OpenElement(119, "option");
            __builder.AddAttribute(120, "value", "12");
            __builder.AddContent(121, 
#nullable restore
#line 53 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                    Strings.IsNotNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\n");
#nullable restore
#line 54 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\n");
#nullable restore
#line 57 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(126, "                                    ");
            __builder.OpenElement(127, "div");
            __builder.AddMarkupContent(128, "\n                                        ");
            __builder.OpenElement(129, "select");
            __builder.AddAttribute(130, "class", "grid-filter-type form-control");
            __builder.AddAttribute(131, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                             _filters[j].Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Type = __value, _filters[j].Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(133, "\n                                            ");
            __builder.OpenElement(134, "option");
            __builder.AddAttribute(135, "value", "1");
            __builder.AddContent(136, 
#nullable restore
#line 62 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.Equal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\n                                            ");
            __builder.OpenElement(138, "option");
            __builder.AddAttribute(139, "value", "10");
            __builder.AddContent(140, 
#nullable restore
#line 63 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                Strings.NotEqual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\n                                            ");
            __builder.OpenElement(142, "option");
            __builder.AddAttribute(143, "value", "5");
            __builder.AddContent(144, 
#nullable restore
#line 64 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.GreaterThan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\n                                            ");
            __builder.OpenElement(146, "option");
            __builder.AddAttribute(147, "value", "6");
            __builder.AddContent(148, 
#nullable restore
#line 65 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.LessThan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n                                            ");
            __builder.OpenElement(150, "option");
            __builder.AddAttribute(151, "value", "7");
            __builder.AddContent(152, 
#nullable restore
#line 66 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.GreaterThanOrEquals

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n                                            ");
            __builder.OpenElement(154, "option");
            __builder.AddAttribute(155, "value", "8");
            __builder.AddContent(156, 
#nullable restore
#line 67 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                               Strings.LessThanOrEquals

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\n");
#nullable restore
#line 68 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                             if (GridHeaderComponent.Column.Filter.IsNullable)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(158, "                                                ");
            __builder.OpenElement(159, "option");
            __builder.AddAttribute(160, "value", "11");
            __builder.AddContent(161, 
#nullable restore
#line 70 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                    Strings.IsNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\n                                                ");
            __builder.OpenElement(163, "option");
            __builder.AddAttribute(164, "value", "12");
            __builder.AddContent(165, 
#nullable restore
#line 71 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                    Strings.IsNotNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\n");
#nullable restore
#line 72 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(167, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\n");
#nullable restore
#line 75 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(170, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\n                            ");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "col-md-6");
            __builder.AddMarkupContent(174, "\n");
#nullable restore
#line 78 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                 if (j == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(175, "                                    ");
            __builder.OpenElement(176, "label");
            __builder.AddAttribute(177, "class", "control-label");
            __builder.OpenElement(178, "b");
            __builder.AddContent(179, 
#nullable restore
#line 80 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                     Strings.FilterValueLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(180, ":");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\n");
#nullable restore
#line 81 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(182, "                                ");
            __builder.OpenElement(183, "div");
            __builder.AddMarkupContent(184, "\n                                    ");
            __builder.OpenElement(185, "input");
            __builder.AddAttribute(186, "type", "date");
            __builder.AddAttribute(187, "placeholder", "yyyy-mm-dd");
            __builder.AddAttribute(188, "class", "grid-filter-input form-control");
            __builder.AddAttribute(189, "value", 
#nullable restore
#line 83 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                                                               _filters[j].Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(190, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 83 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                                                                                             (ChangeEventArgs __e) => _filters[j].Value = __e.Value.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\n");
#nullable restore
#line 87 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(195, "                    ");
            __builder.OpenElement(196, "div");
            __builder.AddAttribute(197, "class", "form-group row");
            __builder.AddAttribute(198, "style", "display:block;");
            __builder.AddMarkupContent(199, "\n                        ");
            __builder.OpenElement(200, "div");
            __builder.AddAttribute(201, "class", "grid-filter-buttons");
            __builder.AddAttribute(202, "style", "float:left;margin-left:15px;");
            __builder.AddMarkupContent(203, "\n                            ");
            __builder.OpenElement(204, "button");
            __builder.AddAttribute(205, "type", "button");
            __builder.AddAttribute(206, "class", "btn btn-primary");
            __builder.AddAttribute(207, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                    ApplyButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(208, "\n                                ");
            __builder.AddContent(209, 
#nullable restore
#line 91 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                 Strings.ApplyFilterButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(210, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\n                        ");
            __builder.OpenElement(213, "div");
            __builder.AddAttribute(214, "class", "grid-filter-buttons");
            __builder.AddAttribute(215, "style", "float:right;margin-right:15px;");
            __builder.AddMarkupContent(216, "\n                            ");
            __builder.OpenElement(217, "button");
            __builder.AddAttribute(218, "type", "button");
            __builder.AddAttribute(219, "class", "btn btn-primary");
            __builder.AddAttribute(220, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                    () => AddColumnFilterValue()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(221, "<b>+</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\n");
#nullable restore
#line 96 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                             if (_filters.Length > 1)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(223, "                                ");
            __builder.OpenElement(224, "button");
            __builder.AddAttribute(225, "type", "button");
            __builder.AddAttribute(226, "class", "btn btn-primary");
            __builder.AddAttribute(227, "style", "margin-left:10px;");
            __builder.AddAttribute(228, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                                                  () => RemoveColumnFilterValue()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(229, "<b>-</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(230, "\n");
#nullable restore
#line 99 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(231, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(233, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, " \n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\n            ");
            __builder.OpenElement(236, "div");
            __builder.AddAttribute(237, "class", "grid-popup-additional");
            __builder.AddMarkupContent(238, "\n");
#nullable restore
#line 105 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                 if (_clearVisible)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(239, "                    ");
            __builder.OpenElement(240, "ul");
            __builder.AddAttribute(241, "class", "menu-list");
            __builder.AddAttribute(242, "style", "margin-top:40px;");
            __builder.AddMarkupContent(243, "\n                        ");
            __builder.OpenElement(244, "li");
            __builder.AddMarkupContent(245, "\n                            ");
            __builder.OpenElement(246, "a");
            __builder.AddAttribute(247, "class", "grid-filter-clear");
            __builder.AddAttribute(248, "href", "javascript:void(0);");
            __builder.AddAttribute(249, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                                                                              ClearButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(250, "\n                                ");
            __builder.AddContent(251, 
#nullable restore
#line 110 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                                 Strings.ClearFilterLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(252, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(254, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(255, "\n");
#nullable restore
#line 114 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(256, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(257, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(258, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(259, "\n");
#nullable restore
#line 118 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\DateTimeFilterComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591