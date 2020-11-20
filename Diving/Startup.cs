using System;
using AutoMapper;
using DivingLogs.Data;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Diving_Log
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
            services.AddMvc(setup => {})
            .AddFluentValidation(options => {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            })
            ;
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
       {
           builder.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();

       }));
            services.AddDbContext<DivingLogContext>(opt => opt.UseSqlServer
            (Configuration.GetConnectionString("DivingConnection")));

            services.AddControllers().AddFluentValidation();            
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped <IDivingLogRepo, SqlDivingLogRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("MyPolicy");
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
