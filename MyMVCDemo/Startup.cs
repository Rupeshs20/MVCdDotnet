 using System.Reflection;
using System.IO;
using System.Threading;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
 
 
 
namespace MyMVCDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
 
        public IConfiguration Configuration { get; }
 
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }
 
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();//middle wear component
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
 
            app.UseAuthorization();
 
            app.Use(async(context, next) =>
            {
                await context.Response.WriteAsync("Company Name is "+ Configuration["Company Name"]);
                await context.Response.WriteAsync("Loglevel Name is "+ Configuration["Logging:LogLevel:default"] + "");
                [Logging]
                await context.Response.WriteAsync("\n this is an First Request in middle ware pipeline");
                await next();
                await context.Response.WriteAsync("\n This is the responese from te first middle wear Compenents");
                //await ContextCallback.Response.WriteAsync("the Process name  of mvc apps"+ System.ServicesProcess.GetCurrentProcess().Id);
                await context.Response.WriteAsync("\nthe Process name of mvc apps" + System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            });
            // app.Use(async(context, next) =>
            // {
            //     await context.Response.WriteAsync("\n this is an Second Request in middle ware pipeline");
            //     await next();
            //     await context.Response.WriteAsync("\n This is the responese from te Second middle wear Compenents");
            // });
 
            app.UseMiddlewear<SampleMiddlewear>();
 
            app.Run(async(context) =>
            {
                await context.Response.WriteAsync("\n This is the end (Terminal) middle wear component");
            });
 
            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapControllerRoute(
            //         name: "default",
            //         pattern: "{controller=Home}/{action=Index}/{id?}");
            // });
        }
    }
}