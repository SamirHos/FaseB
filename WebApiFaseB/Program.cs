using Microsoft.Extensions.DependencyInjection;
using WebApiFaseB.DataAccess;
using WebApiFaseB.Model;
using WebApiFaseB.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//LEGGE ED INIETTA LA CONFIGURAZIONE MONGO
builder.Services.Configure<NegozioDatabaseSettingsClass>(
builder.Configuration.GetSection("NegozioDatabaseSettingsClass"));

//INJECTION Context e Repository
builder.Services.AddScoped<NegozioDatabaseSettingsClass, NegozioDatabaseSettingsClass>();
builder.Services.AddScoped<INegozioContext, NegozioContext>();
builder.Services.AddScoped<IProdottiService, ProdottiService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
