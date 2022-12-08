using Duozin.Data;
using Microsoft.EntityFrameworkCore;
using Duozin.Repositories.interfaces;
using Duozin.Repositories;
using Duozin.Controllers;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataBaseContext>();
builder.Services.AddTransient<IMidRepository, MidRepository>();
builder.Services.AddTransient<IDuozinRepository, DuozinRepository>();

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
    pattern: "{controller=Duozin}/{action=Index}/{id?}");

app.Run();



