#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf219c4c94bd286e0f61363ed672f0dfcc46923"
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
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
    public partial class TextFilterComponent<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                    _offset > 0 ? "margin-left:-" + _offset.ToString() + "px;" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                                                                                                  FilterKeyup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(5, "onclick", true);
            __builder.AddEventStopPropagationAttribute(6, "onkeyup", true);
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 7 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                                                                            textFilter = __value;

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
#line 8 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 12 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 19 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 20 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 21 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 25 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 30 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 31 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 32 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 36 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 39 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 41 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
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
#line 43 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                                _filters[j].Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Type = __value, _filters[j].Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(88, (__value) => {
#nullable restore
#line 43 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                      firstSelect = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(89, "\n                                            ");
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", "2");
            __builder.AddContent(92, 
#nullable restore
#line 44 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.Contains

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\n                                            ");
            __builder.OpenElement(94, "option");
            __builder.AddAttribute(95, "value", "1");
            __builder.AddContent(96, 
#nullable restore
#line 45 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.Equal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n                                            ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", "10");
            __builder.AddContent(100, 
#nullable restore
#line 46 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                Strings.NotEqual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n                                            ");
            __builder.OpenElement(102, "option");
            __builder.AddAttribute(103, "value", "3");
            __builder.AddContent(104, 
#nullable restore
#line 47 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.StartsWith

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\n                                            ");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value", "4");
            __builder.AddContent(108, 
#nullable restore
#line 48 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.EndsWith

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n                                            ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "11");
            __builder.AddContent(112, 
#nullable restore
#line 49 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                Strings.IsNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\n                                            ");
            __builder.OpenElement(114, "option");
            __builder.AddAttribute(115, "value", "12");
            __builder.AddContent(116, 
#nullable restore
#line 50 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                Strings.IsNotNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\n");
#nullable restore
#line 53 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(120, "                                    ");
            __builder.OpenElement(121, "div");
            __builder.AddMarkupContent(122, "\n                                        ");
            __builder.OpenElement(123, "select");
            __builder.AddAttribute(124, "class", "grid-filter-type form-control");
            __builder.AddAttribute(125, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                             _filters[j].Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Type = __value, _filters[j].Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(127, "\n                                            ");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", "2");
            __builder.AddContent(130, 
#nullable restore
#line 58 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.Contains

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\n                                            ");
            __builder.OpenElement(132, "option");
            __builder.AddAttribute(133, "value", "1");
            __builder.AddContent(134, 
#nullable restore
#line 59 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.Equal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\n                                            ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", "10");
            __builder.AddContent(138, 
#nullable restore
#line 60 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                Strings.NotEqual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\n                                            ");
            __builder.OpenElement(140, "option");
            __builder.AddAttribute(141, "value", "3");
            __builder.AddContent(142, 
#nullable restore
#line 61 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.StartsWith

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\n                                            ");
            __builder.OpenElement(144, "option");
            __builder.AddAttribute(145, "value", "4");
            __builder.AddContent(146, 
#nullable restore
#line 62 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                               Strings.EndsWith

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\n                                            ");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "11");
            __builder.AddContent(150, 
#nullable restore
#line 63 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                Strings.IsNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\n                                            ");
            __builder.OpenElement(152, "option");
            __builder.AddAttribute(153, "value", "12");
            __builder.AddContent(154, 
#nullable restore
#line 64 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                Strings.IsNotNull

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\n");
#nullable restore
#line 67 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(158, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\n                            ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "col-md-6");
            __builder.AddMarkupContent(162, "\n");
#nullable restore
#line 70 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                 if (j == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(163, "                                    ");
            __builder.OpenElement(164, "label");
            __builder.AddAttribute(165, "class", "control-label");
            __builder.OpenElement(166, "b");
            __builder.AddContent(167, 
#nullable restore
#line 72 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                     Strings.FilterValueLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(168, ":");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\n");
#nullable restore
#line 73 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(170, "                                ");
            __builder.OpenElement(171, "div");
            __builder.AddMarkupContent(172, "\n                                    ");
            __builder.OpenElement(173, "input");
            __builder.AddAttribute(174, "type", "text");
            __builder.AddAttribute(175, "class", "grid-filter-input form-control");
            __builder.AddAttribute(176, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                     _filters[j].Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(177, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Value = __value, _filters[j].Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\n");
#nullable restore
#line 79 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(182, "                    ");
            __builder.OpenElement(183, "div");
            __builder.AddAttribute(184, "class", "form-group row");
            __builder.AddAttribute(185, "style", "display:block;");
            __builder.AddMarkupContent(186, "\n                        ");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "grid-filter-buttons");
            __builder.AddAttribute(189, "style", "float:left;margin-left:15px;");
            __builder.AddMarkupContent(190, "\n                            ");
            __builder.OpenElement(191, "button");
            __builder.AddAttribute(192, "type", "button");
            __builder.AddAttribute(193, "class", "btn btn-primary");
            __builder.AddAttribute(194, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                    ApplyButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(195, "\n                                ");
            __builder.AddContent(196, 
#nullable restore
#line 83 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                 Strings.ApplyFilterButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(197, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\n                        ");
            __builder.OpenElement(200, "div");
            __builder.AddAttribute(201, "class", "grid-filter-buttons");
            __builder.AddAttribute(202, "style", "float:right;margin-right:15px;");
            __builder.AddMarkupContent(203, "\n                            ");
            __builder.OpenElement(204, "button");
            __builder.AddAttribute(205, "type", "button");
            __builder.AddAttribute(206, "class", "btn btn-primary");
            __builder.AddAttribute(207, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                    () => AddColumnFilterValue()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(208, "<b>+</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\n");
#nullable restore
#line 88 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                             if (_filters.Length > 1)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(210, "                                ");
            __builder.OpenElement(211, "button");
            __builder.AddAttribute(212, "type", "button");
            __builder.AddAttribute(213, "class", "btn btn-primary");
            __builder.AddAttribute(214, "style", "margin-left:10px;");
            __builder.AddAttribute(215, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                                  () => RemoveColumnFilterValue()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(216, "<b>-</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\n");
#nullable restore
#line 91 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(218, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\n            ");
            __builder.OpenElement(223, "div");
            __builder.AddAttribute(224, "class", "grid-popup-additional");
            __builder.AddMarkupContent(225, "\n");
#nullable restore
#line 97 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                 if (_clearVisible)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(226, "                    ");
            __builder.OpenElement(227, "ul");
            __builder.AddAttribute(228, "class", "menu-list");
            __builder.AddAttribute(229, "style", "margin-top:40px;");
            __builder.AddMarkupContent(230, "\n                        ");
            __builder.OpenElement(231, "li");
            __builder.AddMarkupContent(232, "\n                            ");
            __builder.OpenElement(233, "a");
            __builder.AddAttribute(234, "class", "grid-filter-clear");
            __builder.AddAttribute(235, "href", "javascript:void(0);");
            __builder.AddAttribute(236, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                              ClearButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(237, "\n                                ");
            __builder.AddContent(238, 
#nullable restore
#line 102 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                                 Strings.ClearFilterLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(239, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(240, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(242, "\n");
#nullable restore
#line 106 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(243, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(244, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(245, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(246, "\n");
#nullable restore
#line 110 "G:\ATuanLM\AuditProject\Audit\Program\Core\BlazorControl\GridBlazor\Pages\TextFilterComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591