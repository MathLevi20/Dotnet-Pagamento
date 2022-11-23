// Bruno Diego de Resende Castro
// Matheus Levi da Silva Barbosa

using Microsoft.EntityFrameworkCore;
using pagamento.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<MyDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=db;User Id=dotnet_db;Password=12345"));
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