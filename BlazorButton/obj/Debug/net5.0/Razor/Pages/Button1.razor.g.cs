#pragma checksum "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8bb981e3afcfa027f7bd4a41184ebcf9ed36e7f"
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
#line 3 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
using Majorsoft.Blazor.Components.Toggle;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/button1")]
    public partial class Button1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Majorsoft.Blazor.Components.Toggle.ToggleButton>(0);
            __builder.AddAttribute(1, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                        _isButtonChecked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                        _buttonOnColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OffColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                         _buttonOffColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "HoverColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                           _buttonHoverColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                      _buttonWidth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                       _buttonHeight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                         _buttonDisabled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnToggleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 13 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                               OnToggleClicked

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(10, "img");
                __builder2.AddAttribute(11, "src", "https://raw.githubusercontent.com/majorimi/blazor-components/master/src/Blazor.Components.TestApps.Common/wwwroot/place-marker.png");
                __builder2.AddAttribute(12, "width", (
#nullable restore
#line 15 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                                                                                                                                                               _buttonWidth - 5

#line default
#line hidden
#nullable disable
                ) + "px");
                __builder2.AddAttribute(13, "height", (
#nullable restore
#line 15 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                                                                                                                                                                                              _buttonHeight - 5

#line default
#line hidden
#nullable disable
                ) + "px");
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(14, (__value) => {
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
                    _toggleButton = (Majorsoft.Blazor.Components.Toggle.ToggleButton)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenComponent<Majorsoft.Blazor.Components.Toggle.ToggleButton>(16);
            __builder.AddAttribute(17, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<strong>B</strong>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenComponent<Majorsoft.Blazor.Components.Toggle.ToggleButton>(20);
            __builder.AddAttribute(21, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "<i>I</i>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenComponent<Majorsoft.Blazor.Components.Toggle.ToggleButton>(24);
            __builder.AddAttribute(25, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "<u>U</u>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button1.razor"
       
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await _toggleButton.InnerElementReference.FocusAsync();
        }
    }

    //Button
    private ToggleButton _toggleButton;

    private string _buttonOnColor = "lightGray";
    private string _buttonOffColor = "white";
    private string _buttonHoverColor = "WhiteSmoke";
    private int _buttonWidth = 30;
    private int _buttonHeight = 30;
    private bool _isButtonChecked = true;
    private bool _buttonDisabled = false;

    private async Task OnToggleClicked(bool val)
    {
        _isButtonChecked = val;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591