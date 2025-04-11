using MvcStudentDemo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();
// mysql
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql("server=localhost;database=dotnet_mvc;user=root;password=123456",
        new MySqlServerVersion(new Version(8, 0, 36)))); // Chỉnh version theo MySQL bạn dùng


var app = builder.Build();

// Middlewares
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Students}/{action=Index}/{id?}");

app.Run();
