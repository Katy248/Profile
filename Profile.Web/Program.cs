using Profile.Web;
using Profile.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddLocalization();

builder.Services.AddSingleton<DataStore>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseRequestLocalization(new RequestLocalizationOptions()
    .AddSupportedCultures(["es", "ru-RU", "en-US"])
    .AddSupportedUICultures(["es", "ru-RU", "en-US"]));

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
