using GenericRepositoryTest.Context;
<<<<<<< HEAD
using GenericRepositoryTest.Repositories;
using GenericRepositoryTest.Services;
=======
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
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
<<<<<<< HEAD
            
            services.AddScoped<DbContext, ApplicationDBContext>();
            services.AddScoped<IEmployeeRepository,EmployeeRepository>();            
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddMvc();
=======
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
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
