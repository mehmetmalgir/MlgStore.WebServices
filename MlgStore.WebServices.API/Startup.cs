using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MlgStore.Bussiness.Contracts;
using MlgStore.Bussiness.Implementations;
using MlgStore.Bussiness.Mappers.AutoMapper;
using MlgStore.DataAccess.Contracts;
using MlgStore.DataAccess.Implementations.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MlgStore.WebServices.API
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
            services.AddControllers();

            services.AddScoped<IProductBs, EfProductBs>();
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<ICategoryBs, EfCategoryBs>();
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IShippersBs, EfShippersBs>();
            services.AddScoped<IShippersRepository, EfShippersRepository>();
            services.AddScoped<IGendersBs, EfGendersBs>();
            services.AddScoped<IGenderRepository, EfGenderRepository>();
            services.AddScoped<ISizeBs, EfSizeBs>();
            services.AddScoped<ISizeRepository, EfSizeRepository>();
            services.AddScoped<IColorBs, EfColorBs>();
            services.AddScoped<IColorRepository, EfColorRepository>();
			services.AddScoped<IComplaintsBs, EfComplaintsBs>();
			services.AddScoped<IComplaintsRepository, EfComplaintsRepository>();

			services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "MlgStore API",
                    Version = "v1",
                    Description = "Mehmet Serhat MALGIR",
                    Contact = new OpenApiContact
                    {
                        Name = "Mehmet Serhat",
                        Email = string.Empty,
                        Url = new Uri("https://coderjony.com/"),
                    },
                });
            });


            services.AddAutoMapper(typeof(ProductProfile));




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Zomato API V1");

                // To serve SwaggerUI at application's root page, set the RoutePrefix property to an empty string.
                c.RoutePrefix = string.Empty;
            });



            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
