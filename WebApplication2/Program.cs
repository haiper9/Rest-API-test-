using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
var builder = WebApplication.CreateBuilder(args);
string connection = "Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;";
builder.Services.AddDbContext<CitiesContext>(options => options.UseSqlServer(connection));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
