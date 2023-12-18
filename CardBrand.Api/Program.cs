
using CardBrand.Persistence;
using CardBrand.Service.Implements;
using CardBrand.Service.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Get the connection string from appsettings
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddTransient<ICardBrandService, CardBrandService>();
// Configuring Entity Framework to use PostgreSQL with Npgsql as database provider
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseNpgsql(connectionString);
}, ServiceLifetime.Transient);
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
    context.Database.Migrate();
}
  app.UseSwagger();
  app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
