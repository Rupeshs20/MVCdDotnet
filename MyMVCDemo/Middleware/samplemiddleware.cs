using System.Security.AccessControl;
using System.Threading;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using MyMVCDemo.Middleware;


namespace MyMVCDemo.Middleware
{
   public class SampleMiddlewear
    {
        private readonly RequestDelegate _next;
 
        public SampleMiddlewear (RequestDelegate next)
        {
            _next = next ;
        }
 
        public async Task InvokeAsync (HttpContext context)
        {
            await context.Response.WriteAsync ("\n This Request Handler in Sample Middlewear");
            await _next.Invoke(context);
            await context.Response.WriteAsync ("\n this is Response Handler in Sample Middlewear");
        }
    }
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseSample(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SampleMiddlewear>();
        }
    }
}