#pragma checksum "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\CascadingParent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d369ffffaef06708e4ffdeb64e1a56b8a5a4d17"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cascading")]
    public partial class CascadingParent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorButton.Pages.CascadingParent.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\CascadingParent.razor"
                        TheAnswer

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.OpenComponent<BlazorButton.Shared.CascadingChild>(3);
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\CascadingParent.razor"
       
    int TheAnswer = 42;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorButton.Pages.CascadingParent
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