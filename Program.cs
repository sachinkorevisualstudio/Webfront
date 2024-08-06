using Microsoft.EntityFrameworkCore;
using Webfront.Models;

var builder = WebApplication.CreateBuilder(args);

// Set DataDirectory to the root directory of your project
string dataDirectoryPath = builder.Environment.ContentRootPath;
AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register DbContext with dependency injection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseJet(connectionString));

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
    pattern: "{controller=TblDispatches}/{action=Index}/{id?}");

app.Run();
