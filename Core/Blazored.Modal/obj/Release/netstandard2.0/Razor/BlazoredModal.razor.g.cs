#pragma checksum "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\BlazoredModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eaeed672385535efeb815453340eb46590bace2"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazored.Modal
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
    public partial class BlazoredModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Blazored.Modal.BlazoredModal.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#line 1 "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\BlazoredModal.razor"
                       this

#line default
#line hidden
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __Blazor.Blazored.Modal.BlazoredModal.TypeInference.CreateCascadingValue_1(__builder2, 4, 5, 
#line 2 "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\BlazoredModal.razor"
                           GlobalModalOptions

#line default
#line hidden
                , 6, (__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n");
#line 3 "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\BlazoredModal.razor"
         foreach (var modal in Modals)
        {
            

#line default
#line hidden
                    __builder3.AddContent(8, 
#line 5 "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\BlazoredModal.razor"
             modal.ModalInstance

#line default
#line hidden
                    );
#line 5 "G:\ATuanLM\AuditProject\Audit\Program\Core\Blazored.Modal\BlazoredModal.razor"
                                
        }

#line default
#line hidden
                    __builder3.AddContent(9, "    ");
                }
                );
                __builder2.AddMarkupContent(10, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Blazored.Modal.BlazoredModal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591