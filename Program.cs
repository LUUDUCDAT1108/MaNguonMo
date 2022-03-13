using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MvcLUUDUCDAT_MaNguonMoContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcLUUDUCDAT_MaNguonMoContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MvcLUUDUCDAT_MaNguonMoContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MvcLUUDUCDAT_MaNguonMoContext")));
}
else
{
    builder.Services.AddDbContext<MvcLUUDUCDAT_MaNguonMoContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMvcLUUDUCDAT_MaNguonMoContext")));
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
