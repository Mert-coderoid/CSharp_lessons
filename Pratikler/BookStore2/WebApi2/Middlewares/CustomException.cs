using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApi2.Services;

namespace WebApi2.Middlewares
{
    public class CustomException
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomException> _Logger;
        public CustomException(RequestDelegate next, ILogger<CustomException> logger)
        {
            _next = next;
            _Logger = logger;
        }

        public async Task Invoke(HttpContext context)   // context is the request which is coming in
        {
            var watch = Stopwatch.StartNew();   // stopwatch to measure the time taken to process the request
            try
            {
                string message = $"Request {context.Request.Method} {context.Request.Path} {context.Request.QueryString}";
                _Logger.LogInformation(message);
                await _next(context);   // if there is no exception, then the request will be processed
                watch.Stop();
            }
            catch (Exception ex)
            {
                watch.Stop();
                await HandleExceptionAsync(context, ex, watch);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex, Stopwatch watch)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = $"[Error]    HTTP {context.Request.Method} {context.Request.QueryString} responded {context.Response.StatusCode} Error Message: {ex.Message} in {watch.ElapsedMilliseconds} ms";

            var result = JsonConvert.SerializeObject(new { error = ex.Message }, Formatting.Indented);
            return context.Response.WriteAsync(result);
        }
    }

    public static class CustomExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomException(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomException>();
        }
    }
}