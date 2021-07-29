using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sahib.az.WebApplicationUI.Models.Entity.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        async public Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("SignIn", "Account", new
            {
                area = ""
            });
        }
    }
}
