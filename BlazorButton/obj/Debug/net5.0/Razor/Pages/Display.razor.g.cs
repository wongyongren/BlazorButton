#pragma checksum "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Display.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e447f5ea83907612a00c2980cf68fc3b6113bf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorButton.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using BlazorButton;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using BlazorButton.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\source\repos\BlazorButton\BlazorButton\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/display")]
    public partial class Display : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-j5y48zdilb>Display</h3>\r\n");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Display.razor"
 boolvalue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __Blazor.BlazorButton.Pages.Display.TypeInference.CreateCascadingValue_0(__builder, 3, 4, 
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Display.razor"
                        boolvalue

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "toggle-wrapper");
                __builder2.AddAttribute(8, "b-j5y48zdilb");
                __builder2.OpenElement(9, "label");
                __builder2.AddAttribute(10, "class", "toggle");
                __builder2.AddAttribute(11, "b-j5y48zdilb");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "checkbox");
                __builder2.AddAttribute(14, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Display.razor"
                          boolvalue

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => boolvalue = __value, boolvalue));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.AddAttribute(16, "b-j5y48zdilb");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n            <span class=\"toggler round\" b-j5y48zdilb></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenComponent<BlazorButton.Pages.Button2>(19);
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(20, "\r\n\r\n<br b-j5y48zdilb>\r\n<br b-j5y48zdilb>\r\n<br b-j5y48zdilb>\r\n<br b-j5y48zdilb>");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Display.razor"
       
    bool boolvalue = false;


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorButton.Pages.Display
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
    }
}
#pragma warning restore 1591
