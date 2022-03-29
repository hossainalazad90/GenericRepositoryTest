using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Extentions
{
    public static class ServiceExtension
    {

        public static void ConfigureCors(this IServiceCollection services)
        {
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

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }
    }
}
