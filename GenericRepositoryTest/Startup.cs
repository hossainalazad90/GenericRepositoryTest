using Autofac;
using GenericRepositoryTest.Context;
using GenericRepositoryTest.GenericRepository;
using GenericRepositoryTest.Repositories;
using GenericRepositoryTest.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GenericRepositoryTest
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
            services.AddDbContext<ApplicationDBContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            

            services.AddScoped<DbContext, ApplicationDBContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();            
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddMvc();

             #region Enable CORS for cross domain call

            //any origin
            services.AddCors(options => options.AddPolicy("CORSPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            }));

            //Specefic origin
            //services.AddCors(options => options.AddPolicy("CORSPolicy", builder =>
            //{
            //    builder.WithOrigins("http://example.com", "http://example.net")
            //           .AllowAnyMethod()
            //           .AllowAnyHeader();
            //}));
            #endregion Enable CORS for cross domain call

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("CORSPolicy");
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
