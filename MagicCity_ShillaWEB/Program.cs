using MagicCity_ShillaWEB.Services;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;
using Microsoft.AspNetCore.Authentication.Cookies;

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

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.LoginPath = "/LocalUsers/Login";
        options.AccessDeniedPath = "/LoginUsers/AccessDenied";
        options.LogoutPath = "/LocalUsers/Logout";
        options.SlidingExpiration = true;
    });
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
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=LocalUsers}/{action=Login}/{id?}");

app.Run();
