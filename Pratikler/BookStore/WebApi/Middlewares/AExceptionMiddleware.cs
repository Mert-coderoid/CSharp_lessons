using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApi.Services;

namespace WebApi.Middlewares
{
    public class AExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AExceptionMiddleware> _logger;
        private readonly ILoggerService _loggerService;


        public AExceptionMiddleware(RequestDelegate next, ILogger<AExceptionMiddleware> logger, ILoggerService loggerService)
        {
            _next = next;
            _logger = logger;
            _loggerService = loggerService;
        }

        public async Task Invoke(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                string message = $"Request {context.Request.Method} {context.Request.Path} {context.Request.QueryString}";
                _loggerService.Write(message);
                await _next(context);
                watch.Stop();
                message = $"Response {context.Request.Method} {context.Request.Path} {context.Request.QueryString} responded {context.Response.StatusCode} in {watch.ElapsedMilliseconds} ms";
                _loggerService.Write(message);
            }
            catch (Exception ex)
            {
                watch.Stop();
                _logger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, ex, watch);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception, Stopwatch watch)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = $"[Error]    HTTP {context.Request.Method} {context.Request.QueryString} responded {context.Response.StatusCode} Error Message: {exception.Message} in {watch.ElapsedMilliseconds} ms";
            // to use _loggerService to here you need to add it to the constructor 
            // and add it to the services in Program.cs
            _loggerService.Write(message);

            var result = JsonConvert.SerializeObject(new { error = exception.Message }, Formatting.Indented);
            return context.Response.WriteAsync(result);
        }
    }

    public static class AExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseAExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AExceptionMiddleware>();
        }
    }
}