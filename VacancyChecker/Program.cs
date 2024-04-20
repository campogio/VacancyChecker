using Microsoft.EntityFrameworkCore;
using VacancyChecker.Models;
using VacancyChecker.ServiceInterfaces;
using VacancyChecker.Services;
using VacancyChecker.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<VacancyCheckerContext>(options => options.UseSqlServer("DefaultConnection"));
builder.Services.AddScoped<IBedService,BedService>();
builder.Services.AddScoped<IHospitalService, HospitalService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

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
