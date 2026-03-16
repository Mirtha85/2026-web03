using Microsoft.EntityFrameworkCore;
using tienda_electrodomesticos.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TiendaElectrodomesticosDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("TiendaElectrodomesticosDbContextConnection"));
});

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IApplianceRepository, ApplianceRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Appliance}/{action=List}/{id?}");

DbInitializer.Seed(app);

app.Run();
