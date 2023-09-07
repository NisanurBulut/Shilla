using MagicCity_ShillaWEB.Services;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(MappingConfig));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IShillaService, ShillaService>();

builder.Services.AddScoped<IShillaService, ShillaService>();

builder.Services.AddHttpClient<IShillaNumberService, ShillaNumberService>();

builder.Services.AddScoped<IShillaNumberService, ShillaNumberService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
