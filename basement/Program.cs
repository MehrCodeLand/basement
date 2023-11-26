using Data.Leyer.MyDbRoom;
using Microsoft.EntityFrameworkCore;
using Service.Leyer.Repositories.ArtistRepo;
using Service.Leyer.Repositories.ValidationRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDb>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("SqlConn")
    ));
builder.Services.AddScoped<IArtistRepository, ArtistRepository>();
builder.Services.AddScoped<IValidationRepository, ValidationRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
