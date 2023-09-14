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
builder.Services.AddHttpClient<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
