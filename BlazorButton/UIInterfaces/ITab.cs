using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorButton.UIInterfaces
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}