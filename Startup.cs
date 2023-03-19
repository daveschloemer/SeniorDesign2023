using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreshBooks.Data;
using FreshBooks.Data.Service;
using FreshBooks.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace FreshBook
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //DBContext
            services.AddDbContext<BookDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));

            //Services
            services.AddScoped<IBookService, BookService>();


            services.AddControllersWithViews();

            //Authentication and Authorization
            services.AddIdentity<ApplicationUser,IdentityRole>().AddEntityFrameworkStores<BookDbContext>();
            services.AddMemoryCache();
            services.AddSession();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            //Authentication and Authorization
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Home}/{id?}");
            });


            //Seed database
            AppDbInitializer.Seed(app);
            AppDbInitializer.SeedUsersAndRolesAsync(app).Wait();

        }

        public class StartupEmail
        {
            // ...
            public IConfiguration Configuration { get; }

            public StartupEmail(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public void ConfigureServices(IServiceCollection services)
            {
                services.Configure<SmtpConfig>(Configuration.GetSection("SmtpConfig"));
            }
        }

    }
}


