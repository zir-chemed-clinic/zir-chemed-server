using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
//using Microsoft.OpenApi.Models;

namespace zirChemed
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
            services.AddScoped(typeof(IClinicVisitsBl), typeof(ClinicVisitsBl));
            services.AddScoped(typeof(IClinicVisitsDl), typeof(ClinicVisitsDl));
            services.AddScoped(typeof(IEmployeesBl), typeof(EmployeesBl));
            services.AddScoped(typeof(IEmployeesDl), typeof(EmployeesDl));
            services.AddScoped(typeof(IInseminationBl), typeof(InseminationBl));
            services.AddScoped(typeof(IInseminationDl), typeof(InseminationDl));
            services.AddScoped(typeof(IIuiBl), typeof(IuiBl));
            services.AddScoped(typeof(IIuiDl), typeof(IuiDl));
            services.AddScoped(typeof(IPctBl), typeof(PctBl));
            services.AddScoped(typeof(IPctDl), typeof(PctDl));
            services.AddScoped(typeof(ISaBl), typeof(SaBl));
            services.AddScoped(typeof(ISaDl), typeof(SaDl));
            services.AddScoped(typeof(ISubsidizationBl), typeof(SubsidizationBl));
            services.AddScoped(typeof(ISubsidizationDl), typeof(SubsidizationDl));
            services.AddScoped(typeof(ITreatmentsBl), typeof(TreatmentsBl));
            services.AddScoped(typeof(ITreatmentsDl), typeof(TreatmentsDl));
            services.AddScoped(typeof(IPersonsBl), typeof(PersonsBl));
            services.AddScoped(typeof(IPersonsDl), typeof(PersonsDl));
            services.AddScoped(typeof(IUsersBL), typeof(UsersBL));
            services.AddScoped(typeof(IUsersDl), typeof(UsersDl));
            services.AddScoped(typeof(IEmailBL), typeof(EmailBL));
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddDbContext<zirChemedContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ZirchemedDB")));
            services.AddControllers();
            //services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" }); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.Map("/api", app2 =>
            {
                app.UseHttpsRedirection();
                app2.UseRouting();
                app2.UseMiddleware();
                app2.UseAuthorization();
                app2.UseStaticFiles();
                app2.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseSwagger();
            //app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Api v1"); });
        }
    }
}
