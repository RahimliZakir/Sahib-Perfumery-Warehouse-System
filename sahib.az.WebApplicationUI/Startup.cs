using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using sahib.az.WebApplicationUI.AppCode.BinderProviders;
using sahib.az.WebApplicationUI.AppCode.Providers;
using sahib.az.WebApplicationUI.Models.DataContext;
using sahib.az.WebApplicationUI.Models.Entity.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI
{
    public class Startup
    {
        private readonly IConfiguration conf;

        public Startup(IConfiguration conf)
        {
            this.conf = conf;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseQueryStrings = true;
                options.LowercaseUrls = true;
            });

            services.AddControllersWithViews(cfg =>
            {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());

                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            })
            .AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<SahibDbContext>(cfg =>
            {
                cfg.UseSqlServer(conf.GetConnectionString("cStringLocal"));
            });


            services.AddIdentity<AppUser, AppRole>()
                    .AddEntityFrameworkStores<SahibDbContext>()
                    .AddDefaultTokenProviders();

            services.AddScoped<UserManager<AppUser>>()
                    .AddScoped<RoleManager<AppRole>>()
                    .AddScoped<SignInManager<AppUser>>();

            services.AddScoped<IClaimsTransformation, ClaimsTransformationProvider>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 1;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.AllowedForNewUsers = true;

                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

                options.LoginPath = "/signin.html";
                // options.AccessDeniedPath = "/accessdenied.html";
                options.SlidingExpiration = true;

                options.Cookie.Name = ".SAHIB.Cookie.Analyisers";
                options.Cookie.SameSite = SameSiteMode.Strict;
            });

            services.AddAuthorization(cfg =>
            {
                string[] principals = Program.principals;

                foreach (string principal in principals)
                {
                    cfg.AddPolicy(principal, options =>
                    {
                        options.RequireClaim(principal, "1");
                    });
                }
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.DataSeed();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "SignInRoute",
                    pattern: "signin.html",
                    defaults: new
                    {
                        action = "SignIn",
                        controller = "Account"
                    });

                endpoints.MapAreaControllerRoute(name: "adminArea",
                    areaName: "admin",
                    pattern: "{controller=AnswerSystem}/{action=Index}/{id?}");
            });
        }
    }
}
