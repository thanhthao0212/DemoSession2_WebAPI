
using DemoSession2_WebAPI.Converters;
using DemoSession2_WebAPI.Models;
using DemoSession2_WebAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<DatabaseContext>(option => option.UseLazyLoadingProxies().UseSqlServer(connectionString));

builder.Services.AddScoped<ProductServices, ProductServicesImpl>();

builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.Converters.Add(new DateConverter());
});


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.UseStaticFiles();

app.Run();
