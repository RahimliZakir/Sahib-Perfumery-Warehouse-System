using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sahib.az.WebApplicationUI.Models.DataContext;
using sahib.az.WebApplicationUI.Models.Entity.Membership;
using sahib.az.WebApplicationUI.Models.FormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Controllers
{
    public class AccountController : Controller
    {
        readonly SahibDbContext db;
        readonly UserManager<AppUser> userManager;
        readonly RoleManager<AppRole> roleManager;
        readonly SignInManager<AppUser> signInManager;

        public AccountController(SahibDbContext db, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult SignIn()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        async public Task<IActionResult> SignIn(SignInFormModel formModel)
        {
            Regex emailpattern = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            AppUser appUser = null;

            if (emailpattern.IsMatch(formModel.Username))
            {
                appUser = await userManager.FindByEmailAsync(formModel.Username);
            }
            else
            {
                appUser = await userManager.FindByNameAsync(formModel.Username);
            }

            if (appUser != null)
            {
                var signInResult = await signInManager.PasswordSignInAsync(appUser, formModel.Password, false, true);

                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "AnswerSystem", new
                    {
                        area = "Admin"
                    });
                }
                else if (signInResult.IsLockedOut)
                {
                    ViewBag.Locked = "Sizin hesabınız bir müddətlik dondurulub!";
                }
                else
                {
                    ViewBag.SignInFail = "İstifadəçi adı və ya şifrə yanlışdır!";
                }
            }
            else
            {
                ViewBag.SignInFail = "İstifadəçi adı və ya şifrə yanlışdır!";
            }

            return View();
        }
    }
}
