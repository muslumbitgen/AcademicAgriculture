using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademicAgriculture.Web.Entities;
using AcademicAgriculture.Web.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AcademicAgriculture.Web
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
            services.AddDbContext<CustomIdentityDbContext>
              (options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AcademicAgricultureDb;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options => {
                options.Password.RequireDigit = true;//Þifre içinde sayýsal deðer
                options.Password.RequireLowercase = true;//min 1 küçük harf
                options.Password.RequireUppercase = true;//min 1 büyük harf
                options.Password.RequiredLength = 6;//min 6 karakter
                options.Password.RequireNonAlphanumeric = false;
                options.Lockout.MaxFailedAccessAttempts = 5;//5 seferden fazla login iþlemi yapýnca kitlenir
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);// 5 dk boyunca kitlenir
                options.Lockout.AllowedForNewUsers = true;//yeni kullanýcýlarýn da kitlemeye açýldý
                options.User.RequireUniqueEmail = false;
                options.SignIn.RequireConfirmedEmail = false;//mail ile onaylanmasý lazým
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LoginPath = "/account/logOff";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".Academic.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });
            services.AddMvc();
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager)
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

            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedIdentity.Seed(userManager, roleManager, Configuration);

        }
    }
}
