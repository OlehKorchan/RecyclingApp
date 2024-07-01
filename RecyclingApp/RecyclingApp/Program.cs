using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecyclingApp.DataAccess;
using RecyclingApp.DataAccess.Interfaces;
using RecyclingApp.DataAccess.Models;
using RecyclingApp.DataAccess.Repositories;
using RecyclingApp.Orchestrators;
using RecyclingApp.Orchestrators.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "default",
        policy  =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyHeader();
        });
});

builder.Services.AddEntityFrameworkSqlServer();
builder.Services.AddDbContext<ApplicationContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlDb")));

builder.Services.AddTransient<ILocationsOrchestrator, LocationsOrchestrator>();
builder.Services.AddTransient<ILocationsRepository, LocationsRepository>();
builder.Services.AddTransient<IRepository<RecyclingPlace>, Repository<RecyclingPlace>>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors("default");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();