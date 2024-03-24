using Microsoft.EntityFrameworkCore;
using MusicWebsite.Models;
using Microsoft.AspNetCore.Identity;
using MusicWebsite.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MusicWebsiteContextConnection") ?? throw new InvalidOperationException("Connection string 'MusicWebsiteContextConnection' not found.");

// Add services to the container.
var connectString = builder.Configuration["Connection:DefaultString"];
builder.Services.AddDbContext<MusicWebsiteContext>(option => option.UseSqlServer(connectString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MusicWebsiteContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
