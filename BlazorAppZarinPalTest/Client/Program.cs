using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorAppZarinPalTest.Client.Interfaces;
using BlazorAppZarinPalTest.Client.Services;

namespace BlazorAppZarinPalTest.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //add and Create appsettings.json in WWROOT
            string baseAddress = builder.Configuration.GetValue<string>("Url:BaseUrl");
            builder.Services.AddSingleton(new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            });

            builder.Services.AddTransient<IPayment, PaymentRequestService>();

            
            await builder.Build().RunAsync();
        }
    }
}
