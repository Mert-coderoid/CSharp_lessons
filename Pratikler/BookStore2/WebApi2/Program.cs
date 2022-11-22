using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApi2.DBOperations;
using WebApi2.Middlewares;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BookStoreDBContext>(options => options.UseInMemoryDatabase(databaseName: "BookStoreDB"));
// add in-memory database

// Add services to the container.

// Add AutoMapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// ILogger
// builder.Services.AddLogging();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using(var scope = app.Services.CreateAsyncScope())
{
    var services = scope.ServiceProvider;
    DataGenerator.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCustomException();

app.MapControllers();

app.Run();
