#pragma checksum "C:\Users\user\source\repos\BlazorButton\BlazorButton\Shared\CascadingChild.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec25ebe76f215f2a9304c28d0f5330f226054a73"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorButton.Shared
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
    public partial class CascadingChild : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Foo Component</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "The meaning of life is ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Shared\CascadingChild.razor"
                           MeaningOfLife

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Shared\CascadingChild.razor"
               MeaningOfLife

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MeaningOfLife = __value, MeaningOfLife));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Shared\CascadingChild.razor"
       
    [CascadingParameter] int MeaningOfLife { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
