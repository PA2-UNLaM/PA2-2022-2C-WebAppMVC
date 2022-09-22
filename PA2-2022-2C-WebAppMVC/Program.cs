using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PA2_2022_2C_WebAppMVC.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PA2_2022_2C_WebAppMVCContext") ?? throw new InvalidOperationException("Connection string 'PA2_2022_2C_WebAppMVCContext' not found.")));

// Agregamos IProvincias al scope
builder.Services.AddScoped<IProvinciasRepository, EFProvinciasRepository>();

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
