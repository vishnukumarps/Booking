using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maintenance.DbModels;
using Maintenance.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Maintenance.Repository;
using Maintenance.IRepository;
using O3BookingApplication.IRepository;
using O3BookingApplication.Repository;

namespace O3BookingApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
          /*  var builder = new ConfigurationBuilder()
                          .SetBasePath(env.ContentRootPath)
                           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddJsonFile($"appsettings:json.{env.EnviornmentName}.json", optional: true)
                            .AddEnviormentVariables();
*/


            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

           
              services.AddControllersWithViews();
            services.AddMvc();
            services.AddSingleton<IServiceRepository, ServiceRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.Configure<Settings>(o => { o.iConfigurationRoot = (IConfigurationRoot)Configuration; });


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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
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
