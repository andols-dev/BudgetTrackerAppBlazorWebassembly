using Blazored.Toast;
using BudgetTrackerAppBlazorWebassembly;
using BudgetTrackerAppBlazorWebassembly.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IExpensiveService, ExpensiveService>();
builder.Services.AddBlazoredToast();
builder.Services.AddLogging();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
