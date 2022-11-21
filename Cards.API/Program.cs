using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using Cards.API.Data;
using Microsoft.EntityFrameworkCore;
using static Cards.API.Controllers.CardsController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddHttpContextAccessor();

var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? Environments.Production;
builder.Configuration
    .AddCommandLine(args)
    .AddJsonFile($"appsettings.json")
    .AddJsonFile($"appsettings.{env}.json")
    .AddEnvironmentVariables();

builder.Services.AddDbContext<CardsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(CardsContext))));

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
