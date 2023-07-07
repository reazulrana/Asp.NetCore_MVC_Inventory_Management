﻿using InevntoryManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;


namespace InevntoryManagement
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            this._config = config;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {



            services.AddDbContext<ApplicationDbContext>
            (options => options.UseSqlServer(_config.GetConnectionString("DatabasDbConnection")));

            services.AddDbContext<AppDbContext>
            (options => options.UseSqlServer(_config.GetConnectionString("DatabasDbConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddControllers().AddNewtonsoftJson();


            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddMvc(options=>options.EnableEndpointRouting=false);
            
            //for enable httpcontext session variable
            
            services.AddHttpContextAccessor();
            services.AddSession();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();


            //To Activate Session
            app.UseSession();


            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.UseMvc(route =>
            //{
            //    route.MapRoute("default", "{controller=Home}/{action=index}/{id?}");

            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}