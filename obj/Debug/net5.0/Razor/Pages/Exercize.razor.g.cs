#pragma checksum "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\Pages\Exercize.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd29641ae23599fc7bc69dfdd26d32793f4c4fa2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/exercize")]
    public partial class Exercize : ExercizeModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Demo</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p class=\"demo\"> This is demo for Blazor</p>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row m-1 p-1");
            __builder.OpenElement(4, "p");
#nullable restore
#line 8 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\Pages\Exercize.razor"
__builder.AddContent(5, Time);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\Pages\Exercize.razor"
                       GetTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Press me");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control m-1 p-1");
#nullable restore
#line 13 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\Pages\Exercize.razor"
         foreach (var item in Enum.GetNames<Status>())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 15 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\Pages\Exercize.razor"
                            item

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 15 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\Pages\Exercize.razor"
__builder.AddContent(15, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\yaale\Desktop\Project\WEB\BlazorServer\Pages\Exercize.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "dic");
            __builder.AddAttribute(18, "class", "row m-2 p-2");
            __builder.OpenComponent<global::BlazorServer.Pages.StatusComponent>(19);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
