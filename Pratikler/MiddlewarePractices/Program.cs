using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiddlewarePractices.Middlewares;

var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();

app.UseAuthorization();

// app.Run(async context =>
// {
//     Console.WriteLine("Hello World! 1");
// });

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Hello World! 2");
//     await next.Invoke();
//     Console.WriteLine("Middleware 2 sonlandırılıyor...");
// });

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Hello World! 3");
//     await next.Invoke();
//     Console.WriteLine("Middleware 3 sonlandırılıyor...");
// });

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Hello World! 4");
//     await next.Invoke();
//     Console.WriteLine("Middleware 4 sonlandırılıyor...");
// });

app.UseHello();

app.Use(async (context, next) =>
{
    Console.WriteLine("Use Middleware tetiklendi.");
    await next.Invoke();
});

app.Map("/example", internalApp =>
    internalApp.Run(async context =>
    {
        Console.WriteLine("example Map Middleware tetiklendi.");
        await context.Response.WriteAsync("example Map Middleware tetiklendi.");
    })
);

app.MapWhen(x => x.Request.Method == "GET", internalApp =>
    internalApp.Run(async context =>
    {
        Console.WriteLine("MapWhen Middleware tetiklendi.");
        await context.Response.WriteAsync("MapWhen Middleware tetiklendi.");
    })
);

// app.Run(async context =>
// {
//     Console.WriteLine("Hello World! 2");
// });


app.MapControllers();

app.Run();
