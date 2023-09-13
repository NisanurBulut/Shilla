using MagicCity_ShillaAPI;
using MagicCity_ShillaAPI.Controllers;
using MagicShilla_Utility.Data;
using MagicCity_ShillaAPI.Logging;
using MagicCity_ShillaAPI.Repository;
using MagicCity_ShillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using MagicShilla_Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Log.Logger = new LoggerConfiguration().MinimumLevel.Error().WriteTo.File("shillaLogs.txt",rollingInterval:RollingInterval.Day).CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddDbContext<ShillaDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"),
    option => option.MigrationsAssembly("MagicCity_ShillaAPI"));

});
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddControllers(option =>
{
   // option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IShillaRepository, ShillaRepository>();
builder.Services.AddScoped<IShillaNumberRepository, ShillaNumberRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddSingleton<ILogging, Logging>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
