using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sahib.az.WebApplicationUI.Models.Entity;
using sahib.az.WebApplicationUI.Models.Entity.Membership;
using sahib.az.WebApplicationUI.Properties.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.DataContext
{
    public static class DataSeeding
    {
        public static IApplicationBuilder DataSeed(this IApplicationBuilder app)
        {
            using (IServiceScope scope = app.ApplicationServices.CreateScope())
            {
                SahibDbContext db = scope.ServiceProvider.GetRequiredService<SahibDbContext>();
                RoleManager<AppRole> roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();
                UserManager<AppUser> userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                db.Database.Migrate();

                if (db.Roles.Any() == false)
                {
                    db.Roles.Add(new AppRole
                    {
                        Name = "Manager",
                        NormalizedName = "MANAGER"
                    });

                    db.SaveChanges();
                }

                var appRole = roleManager.FindByNameAsync("Admin").Result;

                if (appRole == null)
                {
                    appRole = new AppRole
                    {
                        Name = "Admin"
                    };

                    var appResult = roleManager.CreateAsync(appRole).Result;

                    if (appResult.Succeeded)
                    {
                        var appUser = userManager.FindByNameAsync("akhundzadeh").Result;

                        if (appUser == null)
                        {
                            appUser = new AppUser
                            {
                                Name = "Həsənağa",
                                Surname = "Axundzadə",
                                Patronymic = "Hüseynağa",
                                UserName = "akhundzadeh",
                                Email = "akhundzadeh.hasanaga@gmail.com"
                            };

                            var userResult = userManager.CreateAsync(appUser, AdminPassGetter.GetAdminPass()).Result;

                            if (userResult.Succeeded)
                            {
                                var userRoleResult = userManager.AddToRoleAsync(appUser, appRole.Name).Result;
                            }
                        }
                    }
                }
                else
                {
                    var appUser = userManager.FindByNameAsync("akhundzadeh").Result;

                    if (appUser == null)
                    {
                        appUser = new AppUser
                        {
                            Name = "Həsənağa",
                            Surname = "Axundzadə",
                            Patronymic = "Hüseynağa",
                            UserName = "akhundzadeh",
                            Email = "akhundzadeh.hasanaga@gmail.com"
                        };

                        var userResult = userManager.CreateAsync(appUser, AdminPassGetter.GetAdminPass()).Result;

                        if (userResult.Succeeded)
                        {
                            var userRoleResult = userManager.AddToRoleAsync(appUser, appRole.Name).Result;
                        }
                    }
                    else
                    {
                        var userRoleResult = userManager.AddToRoleAsync(appUser, appRole.Name).Result;
                    }
                }

                if (!db.Brands.Any())
                {
                    db.Brands.Add(new Brand
                    {
                        Name = "Gucci"
                    });

                    db.Brands.Add(new Brand
                    {
                        Name = "Tiziana Terenzi"
                    });

                    db.Brands.Add(new Brand
                    {
                        Name = "Yves Saint Laurent"
                    });

                    db.SaveChanges();
                }

                if (!db.Types.Any())
                {
                    db.Types.Add(new PerfumeType
                    {
                        Name = "EDC"
                    });

                    db.Types.Add(new PerfumeType
                    {
                        Name = "EDT"
                    });

                    db.Types.Add(new PerfumeType
                    {
                        Name = "EDP"
                    });

                    db.Types.Add(new PerfumeType
                    {
                        Name = "PRF"
                    });

                    db.SaveChanges();
                }

                if (db.Logos.Any() == false)
                {
                    db.Logos.Add(new Logo
                    {
                        ImagePath = "logo.png"
                    });

                    db.SaveChanges();
                }
            }

            return app;
        }
    }
}
