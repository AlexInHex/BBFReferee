using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBFReferee.Infrastructure.Data;
using BBFReferee.Core.Interfeices;
using BBFReferee.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using BBFReferee.Web.Controllers;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Services;
using BBFReferee.Core.Services;

namespace BBFReferee.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //DbContext
            services.AddDbContext<BBFRefereeDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BBFRefereeMainBase")));

            //Repositories
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            //MVC Services
            services.AddControllersWithViews();

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUserViewModelService, UserViewModelService>();
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
