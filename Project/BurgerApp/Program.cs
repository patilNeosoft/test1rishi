using BurgerApp.Context;
using BurgerApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession();

builder.Services.AddControllersWithViews();
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
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Register}/{action=RegisterUser}/{id?}");

app.Run();
