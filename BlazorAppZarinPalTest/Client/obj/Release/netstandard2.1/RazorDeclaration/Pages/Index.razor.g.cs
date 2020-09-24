#pragma checksum "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "239fbe5ae36c3d322d5300dd7859f3aaf35c7942"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppZarinPalTest.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using BlazorAppZarinPalTest.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\_Imports.razor"
using BlazorAppZarinPalTest.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\Pages\Index.razor"
using BlazorAppZarinPalTest.Client.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\Pages\Index.razor"
using BlazorAppZarinPalTest.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Aalipour\Source\Repos\ZarinPal-Blazor-Web-Assembly\BlazorAppZarinPalTest\Client\Pages\Index.razor"
       

    private PaymentRequest model;
    protected override void OnInitialized()
    {
        model = new PaymentRequest()
        {
            OrderId = "9654823514585",
            amount = 1000,
            description = "Description",
        };
    }

    private async Task<bool> OnValidSubmit()
    {

        var response = await paymentService.PaymentRequestAsync(model);
        if (response.Response.Success == 1)
        {
            navigationManager.NavigateTo(response.Url);
        }

        return await Task.FromResult(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPayment paymentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
