#pragma checksum "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b32dec94f6c5f6fa2dd332aeb4e5cf9032cdadb4"
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
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
using Majorsoft.Blazor.Components.Toggle;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/button")]
    public partial class Button : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Majorsoft.Blazor.Components.Toggle.ToggleSwitch>(0);
            __builder.AddAttribute(1, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                       _value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                        _onColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OffColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                         _offColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                     _widht

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                      _height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "HandleStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Majorsoft.Blazor.Components.Toggle.ToggleSwitchStyle>(
#nullable restore
#line 11 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                           _styleType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                        _disabled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnToggleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 13 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                               OnToggleSwitched

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(9, (__value) => {
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
                    _toggleSwitch = (Majorsoft.Blazor.Components.Toggle.ToggleSwitch)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button.razor"
       
    private ToggleSwitch _toggleSwitch;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await _toggleSwitch.InnerElementReference.FocusAsync();
        }
    }

    private string _onColor = "DodgerBlue";
    private string _offColor = "DarkGray";
    private int _widht = 50;
    private int _height = 22;
    private bool _value = true;
    private bool _disabled = false;
    private ToggleSwitchStyle _styleType = ToggleSwitchStyle.Circle;

    private ElementReference log1;
    private string _swithch1Log;

    private async Task OnToggleSwitched(bool val)
    {
        _value = val;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591