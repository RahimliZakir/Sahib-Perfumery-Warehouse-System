using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sahib.az.WebApplicationUI.AppCode.Extensions;
using sahib.az.WebApplicationUI.Areas.Admin.Models.ViewModel;
using sahib.az.WebApplicationUI.Models.DataContext;
using sahib.az.WebApplicationUI.Models.Entity.Membership;

namespace sahib.az.WebApplicationUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class StaffController : Controller
    {
        private readonly SahibDbContext _context;
        private readonly UserManager<AppUser> userManager;

        public StaffController(SahibDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        // GET: Admin/Staff
        public async Task<IActionResult> Index()
        {
            var viewModel = new StaffUserRoleViewModel();

            IEnumerable<AppUser> data = await _context.Users.Where(u => u.DeletedDate == null).ToListAsync();

            viewModel.Users = data;

            ViewBag.Username = await _context.Users.FirstOrDefaultAsync(u => u.Id == User.GetUserId());

            return View(viewModel);
        }

        //// GET: Admin/Staff/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var appUser = await _context.Users
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (appUser == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(appUser);
        //}

        //// GET: Admin/Staff/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Admin/Staff/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Surname,Patronymic,BirthDate,FinCode,SerialNumber,HomeNumber,LivingAddress,RegistrationAddress,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(appUser);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(appUser);
        //}

        // GET: Admin/Staff/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            // var viewModel = new StaffUserRoleViewModel();

            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            ViewBag.Username = await _context.Users.FirstOrDefaultAsync(u => u.Id == User.GetUserId());

            var viewModel = new StaffUserRoleViewModel
            {
                Id = appUser.Id,
                UserName = appUser.UserName,
                NormalizedUserName = appUser.UserName.ToUpper(),
                Email = appUser.Email,
                NormalizedEmail = appUser.Email.ToUpper(),
                EmailConfirmed = appUser.EmailConfirmed,
                PasswordHash = appUser.PasswordHash,
                SecurityStamp = appUser.SecurityStamp,
                ConcurrencyStamp = appUser.ConcurrencyStamp,
                PhoneNumber = appUser.PhoneNumber,
                PhoneNumberConfirmed = appUser.PhoneNumberConfirmed,
                TwoFactorEnabled = appUser.TwoFactorEnabled,
                LockoutEnd = appUser.LockoutEnd,
                LockoutEnabled = appUser.LockoutEnabled,
                AccessFailedCount = appUser.AccessFailedCount,
                Name = appUser.Name,
                Surname = appUser.Surname,
                Patronymic = appUser.Patronymic,
                BirthDate = appUser.BirthDate,
                FinCode = appUser.FinCode,
                SerialNumber = appUser.SerialNumber,
                HomeNumber = appUser.HomeNumber,
                LivingAddress = appUser.LivingAddress,
                RegistrationAddress = appUser.RegistrationAddress
            };

            //viewModel.User = appUser;

            var thisUsersUserRole = await _context.UserRoles.AsNoTracking().FirstOrDefaultAsync(ur => ur.UserId == id);

            //viewModel.Roles = _context.Roles;

            ViewData["Roles"] = new SelectList(_context.Roles, "Id", "Name", thisUsersUserRole.RoleId);

            return View(viewModel);
        }

        // POST: Admin/Staff/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StaffUserRoleViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //try
                //{
                var appUser = new AppUser
                {
                    Id = viewModel.Id,
                    UserName = viewModel.UserName,
                    NormalizedUserName = viewModel.NormalizedUserName,
                    Email = viewModel.Email,
                    NormalizedEmail = viewModel.NormalizedEmail,
                    EmailConfirmed = viewModel.EmailConfirmed,
                    PasswordHash = viewModel.PasswordHash,
                    SecurityStamp = viewModel.SecurityStamp,
                    ConcurrencyStamp = viewModel.ConcurrencyStamp,
                    PhoneNumber = viewModel.PhoneNumber,
                    PhoneNumberConfirmed = viewModel.PhoneNumberConfirmed,
                    TwoFactorEnabled = viewModel.TwoFactorEnabled,
                    LockoutEnd = viewModel.LockoutEnd,
                    LockoutEnabled = viewModel.LockoutEnabled,
                    AccessFailedCount = viewModel.AccessFailedCount,
                    Name = viewModel.Name,
                    Surname = viewModel.Surname,
                    Patronymic = viewModel.Patronymic,
                    BirthDate = viewModel.BirthDate,
                    FinCode = viewModel.FinCode,
                    SerialNumber = viewModel.SerialNumber,
                    HomeNumber = viewModel.HomeNumber,
                    LivingAddress = viewModel.LivingAddress,
                    RegistrationAddress = viewModel.RegistrationAddress
                };

                appUser.UpdatedDate = DateTime.UtcNow.AddHours(4);

                _context.Update(appUser);
                await _context.SaveChangesAsync();

                int roleId = viewModel.Role.Id;

                var gettedRole = await _context.Roles.AsNoTracking().FirstOrDefaultAsync(r => r.Id == roleId);

                var prevUserRole = await _context.UserRoles.AsNoTracking().FirstOrDefaultAsync(ur => ur.UserId == appUser.Id);
                var prevRole = await _context.Roles.AsNoTracking().FirstOrDefaultAsync(r => r.Id == prevUserRole.RoleId);

                await userManager.RemoveFromRoleAsync(appUser, prevRole.Name);

                await userManager.AddToRoleAsync(appUser, gettedRole.Name);
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!AppUserExists(viewModel.User.Id))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
                //}
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel.User);
        }

        // GET: Admin/Staff/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            ViewBag.Username = await _context.Users.FirstOrDefaultAsync(u => u.Id == User.GetUserId());

            return View(appUser);
        }

        // POST: Admin/Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appUser = await _context.Users.FindAsync(id);
            _context.Users.Remove(appUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
