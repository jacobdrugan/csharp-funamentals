using BethanysPieShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop
{
    public class Startup
    {
        //The Startup of an application
        // 1. Application Starting (Program Class) 
        // 2. Startup Class
        // 3. ConfigureServices Method (Registering Services)
        // 4. Configure Method (Pipeline is created)
        // 5. Ready for Requests


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //register our own services
            services.AddScoped<IPieRepository, MockPieRepository>();
            services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            //services.AddTransient - New Instance
            //services.AddSingleton - Single Instance Per Request
            //register services here through dependency injection
            //register framework services
            services.AddControllersWithViews();


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Add middleware components here
            // Request ---> Middleware 1 ---> Middleware 2 ---> Middleware 3
            // Response <--- Middleware 1 <--- Middleware 2 <--- Middleware 3

            // e.g.
            // Request ---> Response Compression ---> Static Files ---> End Point
            // Response <--- Response Compression <--- Static Files <--- End Point

            //Examples of middleware
            //app.UseDeveloperExceptionPage();
            //app.UseStatusCodePages();
            //app.UseStaticFiles();
            //app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            });
        }
    }
}
