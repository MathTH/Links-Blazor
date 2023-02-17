using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UnimedLinksWEB;
using UnimedLinksWEB.Contrato;
using UnimedLinksWEB.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseUrl = "https://localhost:7185";

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri(baseUrl)
});

builder.Services.AddScoped<InterfaceSite, SiteRepository>();


await builder.Build().RunAsync();
