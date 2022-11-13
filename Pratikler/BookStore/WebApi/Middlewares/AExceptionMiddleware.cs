using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WebApi.Middlewares
{
    public class AExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AExceptionMiddleware> _logger;

        public AExceptionMiddleware(RequestDelegate next, ILogger<AExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                string message = $"Request {context.Request.Method} {context.Request.Path} {context.Request.QueryString}";
                Console.WriteLine(message);
                await _next(context);
                watch.Stop();
                message = $"Response {context.Request.Method} {context.Request.Path} {context.Request.QueryString} responded {context.Response.StatusCode} in {watch.ElapsedMilliseconds} ms";
                Console.WriteLine(message);
            }
            catch (Exception ex)
            {
                watch.Stop();
                _logger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, ex, watch);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, Stopwatch watch)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = $"[Error]    HTTP {context.Request.Method} {context.Request.QueryString} responded {context.Response.StatusCode} Error Message: {exception.Message} in {watch.ElapsedMilliseconds} ms";
            Console.WriteLine(message);


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