#pragma checksum "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf7abfb0bd63a2d7222c3ab233170b9ae796bd86"
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
    public partial class Button3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button3.razor"
 foreach (var check in CheckBoxList())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "class", "custom-checkbox");
            __builder.AddAttribute(2, "type", "checkbox");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button3.razor"
                                                              eventArgs => { CheckboxClicked(check, eventArgs.Value); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddContent(4, 
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button3.razor"
     check

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "<br>");
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button3.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\user\source\repos\BlazorButton\BlazorButton\Pages\Button3.razor"
       

    public List<string> CheckBox { get; set; } = new List<string>();
    void CheckboxClicked(string CheckID, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!CheckBox.Contains(CheckID))
            {
                CheckBox.Add(CheckID);
            }
        }
        else
        {
            if (CheckBox.Contains(CheckID))
            {
                CheckBox.Remove(CheckID);
            }
        }
    }

    public List<String> CheckBoxList()
    {
        List<String> checkBox = new List<String>();
        checkBox.Add("CheckBox 1");
        checkBox.Add("CheckBox 2");
        return checkBox;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
