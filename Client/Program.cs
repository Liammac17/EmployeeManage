using BaseLibrary.Entities;
using Blazored.LocalStorage;
using Client;
using Client.ApplicationState;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using ClientLibrary.Services.Implementations;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;


Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDQ0MDQ0M0AzMjMxMmUzMTJlMzMzNUU1R1dwRGJyMjNuV3BkMVVOdVQxQ05Rd0JMcHBmNjc5dS83VUtPTDJvV289;NDQ0MDQ0NEAzMjMxMmUzMTJlMzMzNUwxMTAyTFlrcTEwQXNmUFkrN2ZjaVdXbytuemdLWUlCcVB1WHlwYkh6NlU9;Mgo+DSMBPh8sVXJ1S0d+X1RPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9lSXZSckRlXXlacXdSTmRXU0U=;ORg4AjUWIQA/Gnt2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hT35bd0FiX3tYdHVWT2RcWkZ3;NRAiBiAaIQQuGjN/V0d+XU9Hc1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3hTfkRnWHladnBUQmFdVU90Xg==;NDQ0MDQ0OEAzMjMxMmUzMTJlMzMzNWNXZW5wRi94MXdsVW9zdXZIWHdWcUsyNGFTejZab2cwbEtGR3BWVnRtSUU9;NDQ0MDQ0OUAzMjMxMmUzMTJlMzMzNW1BWkdzanJmQlBJNldSdnYzWU1hOW9YRWttQUFNUWJJeDRDL2pHSnpwQXc9;Mgo+DSMBMAY9C3t2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hT35bd0FiX3tYdHVQRGBZWkZ3;NDQ0MDQ1MUAzMjMxMmUzMTJlMzMzNWQ1Ty9sc1Zjdm5QcENWUGVuaGNWRWFzWmw3cnIrdjFiOW12RmxRUHQ5SXc9;NDQ0MDQ1MkAzMjMxMmUzMTJlMzMzNWlodHF1YjFTd2tUOG9GbGQ0TERma1JJcElKckdLMVhOd1pZaDdBazRxbm89;NDQ0MDQ1M0AzMjMxMmUzMTJlMzMzNWNXZW5wRi94MXdsVW9zdXZIWHdWcUsyNGFTejZab2cwbEtGR3BWVnRtSUU9");


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<CustomHttpHandler>();
builder.Services.AddHttpClient("SystemApiClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7203/");
}).AddHttpMessageHandler<CustomHttpHandler>();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7203/") });
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<GetHttpClient>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<IUserAccountService, UserAccountService>();

//General Department / Department / Branch
builder.Services.AddScoped<IGenericServiceInterface<GeneralDepartment>, GenericServiceImplementation<GeneralDepartment>>();
builder.Services.AddScoped<IGenericServiceInterface<Department>, GenericServiceImplementation<Department>>();
builder.Services.AddScoped<IGenericServiceInterface<Branch>, GenericServiceImplementation<Branch>>();

//Country / City / Town
builder.Services.AddScoped<IGenericServiceInterface<Country>, GenericServiceImplementation<Country>>();
builder.Services.AddScoped<IGenericServiceInterface<City>, GenericServiceImplementation<City>>();
builder.Services.AddScoped<IGenericServiceInterface<Town>, GenericServiceImplementation<Town>>();

//Employee
builder.Services.AddScoped<IGenericServiceInterface<Employee>, GenericServiceImplementation<Employee>>();

builder.Services.AddScoped<AllState>();

builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<SfDialogService>();

await builder.Build().RunAsync();
