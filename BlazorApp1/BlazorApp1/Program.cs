using BlazorApp1.Client.Pages;
using BlazorApp1.Components;
using BlazorApp1.Components.Account;
using BlazorApp1.Controller;

using BlazorApp1.Data;
using BlazorApp1.Interface;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionStringUsers = builder.Configuration.GetConnectionString("ConnectionForPrinterBuyUsers") ?? throw new InvalidOperationException("Connection string 'ConnectionForPrinterBuyUsers' not found.");
var connectionStringPrinters = builder.Configuration.GetConnectionString("ConnectionForPrinterBuyPrinters") ?? throw new InvalidOperationException("Connection string 'ConnectionForPrinterBuyPrinters' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(connectionStringUsers));
builder.Services.AddDbContext< ApplicationContext > (options => options.UseSqlServer(connectionStringPrinters));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<IImageService, ImageService>();
builder.Services.AddRadzenComponents();
builder.Services.AddRazorComponents(options => options.DetailedErrors = true);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Counter).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
