using designpatterns_api.Data;
using designpatterns_api.Factories;
using designpatterns_api.Interfaces;
using designpatterns_api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("sqlString")));

// Used for Dependency injection to keep leveled with DIP
builder.Services.AddSingleton<IShoeFactory, ShoeFactory>();
builder.Services.AddSingleton<IWatchFactory, WatchFactory>();
builder.Services.AddScoped<IShoeService, ShoeService>();
builder.Services.AddScoped<IWatchService, WatchService>();
//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
