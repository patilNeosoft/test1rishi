using Burger_With_Database_MVC.Context;
using Burger_With_Database_MVC.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAdminS, AdminS>();
builder.Services.AddScoped<IRegisterS, RegisterS>();
var connectionString = builder.Configuration.GetConnectionString("RegisterConnection");
builder.Services.AddDbContext<RegisterDbContext>(u => u.UseSqlServer(connectionString));
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
    pattern: "{controller=Admin}/{action=RegisterAdmins}/{id?}");

app.Run();
