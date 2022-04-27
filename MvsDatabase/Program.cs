using Microsoft.EntityFrameworkCore;
using MvsDatabase.Storage;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;


// Add services to the container.
services.AddControllersWithViews();


//Add Context
var ConnectionString = builder.Configuration.GetConnectionString("Dbconnection");

services.AddDbContext<UniverstiyContext>(Param => Param.UseSqlServer(ConnectionString));


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
