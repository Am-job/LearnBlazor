using BlazorStorageService;
using BlazorStorageService.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Collections.Generic;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton(typeof(JsStorageService<>), typeof(JsStorageService<>));
builder.Services.AddSingleton(typeof(StorageService<>), typeof(StorageService<>));

await builder.Build().RunAsync();
