using Microsoft.EntityFrameworkCore;
using ProjetoCorreiosAPI.Bussines;
using ProjetoCorreiosAPI.Interface;
using ProjetoCorreiosAPI.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region CONFIGURAÇÃO DO BANCO

string connectionString = builder.Configuration.GetConnectionString("String");
builder.Services.AddDbContext<DbCorreiosContext>(op => op.UseSqlServer(connectionString));
#endregion

#region INJEÇÃO DE DEPENDENCIA
builder.Services.AddScoped<ICorreio, CorreioBO>();
#endregion


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
