#pragma checksum "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c49a6c928792929d426a877f6794af3fb6a01c4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppZarinPalTest.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using BlazorAppZarinPalTest.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\_Imports.razor"
using BlazorAppZarinPalTest.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
using BlazorAppZarinPalTest.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
using BlazorAppZarinPalTest.Client.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/verify")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/verify/{OrderId}/")]
    public partial class Verify : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "signin-page");
            __builder.AddAttribute(2, "class", "p-5");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-12");
            __builder.OpenElement(12, "h4");
            __builder.AddMarkupContent(13, "<strong>Authority: </strong>");
            __builder.AddContent(14, 
#nullable restore
#line 14 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
                                                                    Authority

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-12");
            __builder.OpenElement(18, "h4");
            __builder.AddMarkupContent(19, "<strong>Status: </strong>");
            __builder.AddContent(20, 
#nullable restore
#line 15 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
                                                                 Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-md-12");
            __builder.OpenElement(24, "h4");
            __builder.AddMarkupContent(25, "<strong>OrderId: </strong>");
            __builder.AddContent(26, 
#nullable restore
#line 16 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
                                                                  OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-12");
            __builder.OpenElement(30, "h4");
            __builder.AddMarkupContent(31, "<strong>Result: </strong>");
            __builder.AddContent(32, 
#nullable restore
#line 18 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
                                                                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-12");
            __builder.OpenElement(36, "h4");
            __builder.AddMarkupContent(37, "<strong>کد پیگیری: </strong>");
            __builder.AddContent(38, 
#nullable restore
#line 19 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
                                                                    Ref_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Aalipour\source\repos\BlazorAppZarinPalTest\BlazorAppZarinPalTest\Client\Pages\Verify.razor"
       
    [Parameter]
    public string Authority { get; set; }
    [Parameter]
    public string Status { get; set; }
    [Parameter]
    public string OrderId { get; set; }


    public string Message { get; set; }
    public string Ref_id { get; set; }

    protected override void OnInitialized()
    {
        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("Authority", out var auth))
        {
            Authority = auth.First();
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("Status", out var status))
        {
            Status = status.First();
        }
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("OrderId", out var orderid))
        {
            OrderId = orderid.First();
        }
        StateHasChanged();
    }

    protected override async Task OnParametersSetAsync()
    {
        if (Status == null || Status.ToUpper() == "NOK" || Authority == null || Authority == "")
        {
            Message = "انصراف از درخواست";
            return;
        }
        var result = await paymentService.PaymentVerificationAsync(new PaymentVerification()
        {
            authority = Authority,
            amount = 1000,

            OrderId = OrderId,
        });

        if (result.Response.Success == 1)
        {
            Message = result.Response.Message;
            Ref_id = result.data.ref_id.ToString();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPayment paymentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
