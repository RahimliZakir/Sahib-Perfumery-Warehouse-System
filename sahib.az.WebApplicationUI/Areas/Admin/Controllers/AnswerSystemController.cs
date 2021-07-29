using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sahib.az.WebApplicationUI.AppCode.Extensions;
using sahib.az.WebApplicationUI.AppCode.RequestChecker;
using sahib.az.WebApplicationUI.Areas.Admin.Models.FormModel;
using sahib.az.WebApplicationUI.Areas.Admin.Models.ViewModel;
using sahib.az.WebApplicationUI.Models.DataContext;
using sahib.az.WebApplicationUI.Models.Entity;
using sahib.az.WebApplicationUI.Models.Entity.Membership;

namespace sahib.az.WebApplicationUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnswerSystemController : Controller
    {
        private readonly SahibDbContext _context;
        private readonly IWebHostEnvironment env;
        private readonly UserManager<AppUser> userManager;
        // private readonly ILogger logger;

        public AnswerSystemController(SahibDbContext context, IWebHostEnvironment env, UserManager<AppUser> userManager/*, ILogger<AnswerSystemController> logger */)
        {
            _context = context;
            this.env = env;
            this.userManager = userManager;
            // this.logger = logger;
        }

        // GET: Admin/AnswerSystem
        public async Task<IActionResult> Index()
        {
            var viewModel = new AnswerIndexCreateViewModel();

            viewModel.Perfumes = await _context.Perfumes.Include(p => p.Brand).Include(p => p.Type)
                                       .Where(b => b.Brand.DeletedDate == null)
                                       .Where(t => t.Type.DeletedDate == null)
                                       .Where(p => p.DeletedDate == null)
                                       .ToListAsync();

            ViewData["BrandId"] = new SelectList(_context.Brands.Where(b => b.DeletedDate == null), "Id", "Name");
            ViewData["TypeId"] = new SelectList(_context.Types.Where(t => t.DeletedDate == null), "Id", "Name");

            ViewBag.Username = await _context.Users.FirstOrDefaultAsync(u => u.Id == User.GetUserId());

            // logger.LogInformation("Ugurla ishe dushdu!");

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string searchText)
        {
            var viewModel = new AnswerIndexCreateViewModel();

            IQueryable<Perfume> query = _context.Perfumes
                            .Include(b => b.Brand)
                            .Include(t => t.Type)
                            .Where(b => b.Brand.DeletedDate == null)
                            .Where(t => t.Type.DeletedDate == null)
                            .Where(p => p.DeletedDate == null)
                            .AsQueryable();

            if (searchText != null)
            {
                query = query.Where(q => q.Name.ToLower().Contains(searchText.ToLower()));
                //---------------------------------------------------------------------------------------------------------------------------------------------
                //if (await _context.Perfumes.Where(p => p.DeletedDate == null).AnyAsync(p => p.Name.ToLower().IndexOf(searchText.ToLower()) != -1) == true)
                //{
                //    query = query.Where(q => q.Name.ToLower().Contains(searchText.ToLower()));
                //}
                //else if (await _context.Brands.Where(b => b.DeletedDate == null).AnyAsync(b => b.Name.ToLower().IndexOf(searchText.ToLower()) != -1) == true)
                //{
                //    query = query.Where(q => q.Brand.Name.ToLower().Contains(searchText.ToLower()));
                //}
                //else if (searchText.ToLower().StartsWith("m") && await _context.Perfumes.Where(p => p.DeletedDate == null).AnyAsync(p => p.Maya.ToString().IndexOf(searchText.ToLower().Replace("m", "")) != -1) == true)
                //{
                //    searchText = searchText.ToLower().Replace("m", "");
                //    query = query.Where(q => q.Maya.ToString().Contains(searchText));
                //}
                //else if (searchText.ToLower().StartsWith("s") && await _context.Perfumes.Where(p => p.DeletedDate == null).AnyAsync(p => p.Price.ToString().ToLower().IndexOf(searchText.ToLower().Replace("s", "")) != -1) == true)
                //{
                //    searchText = searchText.ToLower().Replace("s", "");
                //    query = query.Where(q => q.Price.ToString().ToLower().Contains(searchText));
                //}
            }

            viewModel.Perfumes = await query.ToListAsync();

            if (Request.IsAjaxRequest())
            {
                return Json(viewModel);
            }

            return View(viewModel);
        }

        [Route("/ishchi-elavesi")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddStaff()
        {
            ViewBag.Username = _context.Users.FirstOrDefault(u => u.Id == User.GetUserId());

            return View();
        }

        [Route("/ishchi-elavesi")]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        async public Task<IActionResult> AddStaff(AddStaffFormModel formModel)
        {
            var appUser = new AppUser
            {
                UserName = formModel.Username,
                Email = formModel.Email
            };

            IEnumerable<AppUser> registeredUsers = await _context.Users.AsNoTracking().ToListAsync();

            var appResult = await userManager.CreateAsync(appUser, formModel.Password);

            if (appResult.Succeeded)
            {
                var appUserRole = await userManager.AddToRoleAsync(appUser, "Manager");

                return RedirectToAction("Index", "AnswerSystem");
            }
            else if (registeredUsers.Any(u => u.UserName == formModel.Username))
            {
                ViewBag.UserDublicate = "Bu adlı istifadəçi artıq var!";
            }
            else
            {
                foreach (IdentityError error in appResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View();
        }

        // GET: Admin/AnswerSystem/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var perfume = await _context.Perfumes
        //        .Include(p => p.Brand)
        //        .Include(p => p.Type)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (perfume == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(perfume);
        //}

        // GET: Admin/AnswerSystem/Create
        //public IActionResult Create()
        //{
        //    ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name");
        //    ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name");
        //    return View();
        //}

        // POST: Admin/AnswerSystem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,BrandId,ML,TypeId,IsTester,Maya,Price,ThreeMonths,SixMonths,NineMonths,TwelveMonths,FifteenMonths,EighteenMonths")] Perfume perfume, IFormFile file)
        {
            if (file == null)
            {
                ModelState.AddModelError("", "Şəkil seçin!");
            }
            else if (file != null)
            {

                string ext = Path.GetExtension(file.FileName);
                string filename = $"perfume-{Guid.NewGuid().ToString().Replace("-", "")}{ext}";
                string fullpath = Path.Combine(env.WebRootPath, "uploads", "perfumes", filename);

                using (var fs = new FileStream(fullpath, FileMode.Create, FileAccess.Write))
                {
                    file.CopyTo(fs);
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        perfume.ImagePath = filename;

                        string three = null;
                        string six = null;
                        string nine = null;
                        string twelve = null;
                        string fifteen = null;
                        string eighteen = null;

                        StringBuilder sb = new StringBuilder();

                        if (perfume.ThreeMonths != 0)
                        {
                            three = $"▪ 3 ay x {perfume.ThreeMonths} azn";
                            sb.AppendLine(three);
                        }

                        if (perfume.SixMonths != 0)
                        {
                            six = $"▪ 6 ay x {perfume.SixMonths} azn";
                            sb.AppendLine(six);

                        }

                        if (perfume.NineMonths != 0)
                        {
                            nine = $"▪ 9 ay x {perfume.NineMonths} azn";
                            sb.AppendLine(nine);
                        }

                        if (perfume.TwelveMonths != 0)
                        {
                            twelve = $"▪ 12 ay x {perfume.TwelveMonths} azn";
                            sb.AppendLine(twelve);
                        }

                        if (perfume.FifteenMonths != 0)
                        {
                            fifteen = $"▪ 15 ay x {perfume.FifteenMonths} azn";
                            sb.AppendLine(fifteen);
                        }

                        if (perfume.EighteenMonths != 0)
                        {
                            eighteen = $"▪ 18 ay x {perfume.EighteenMonths} azn";
                            sb.AppendLine(eighteen);
                        }

                        //                        string main =
                        //$@"{three}
                        //{six}
                        //{nine}
                        //{twelve}
                        //{fifteen}
                        //{eighteen}";

                        //main = Regex.Replace(main, @"\s+", " ");

                        if (perfume.IsTester)
                        {
                            perfume.Description =
@$"{_context.Brands.FirstOrDefault(b => b.Id == perfume.BrandId).Name} - {perfume.Name} ətirinin nağd satış qiyməti:

▪ {perfume.ML} ml - {perfume.Price} azn ({_context.Types.FirstOrDefault(b => b.Id == perfume.TypeId).Name}) TESTER
_________________________

İLKİN ÖDƏNİŞSİZ KREDiT:

{perfume.ML} ML TESTER ÜÇÜN ⬇️

{sb.ToString()}";
                        }
                        else
                        {
                            perfume.Description =
@$"{_context.Brands.FirstOrDefault(b => b.Id == perfume.BrandId).Name} - {perfume.Name} ətirinin nağd satış qiyməti:

▪ {perfume.ML} ml - {perfume.Price} azn ({_context.Types.FirstOrDefault(b => b.Id == perfume.TypeId).Name})
_________________________

İLKİN ÖDƏNİŞSİZ KREDiT:

{perfume.ML} ML ÜÇÜN ⬇️

{sb.ToString()}";
                        }

                        _context.Add(perfume);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (Exception)
                    {
                        if (System.IO.File.Exists(fullpath))
                        {
                            System.IO.File.Delete(fullpath);
                        }
                    }
                }

            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", perfume.BrandId);
            ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name", perfume.TypeId);

            return Json(new
            {
                error = true,
                message = "Melumatlar elave edilerken xeta bash verdi!"
            });
        }

        // GET: Admin/AnswerSystem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfumes.FindAsync(id);
            if (perfume == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", perfume.BrandId);
            ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name", perfume.TypeId);
            ViewBag.Username = await _context.Users.FirstOrDefaultAsync(u => u.Id == User.GetUserId());
            return View(perfume);
        }

        // POST: Admin/AnswerSystem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,BrandId,ML,TypeId,IsTester,Maya,Price,ThreeMonths,SixMonths,NineMonths,TwelveMonths,FifteenMonths,EighteenMonths,ImagePath, CreatedDate, UpdatedDate")] Perfume perfume)
        {
            if (id != perfume.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string three = null;
                    string six = null;
                    string nine = null;
                    string twelve = null;
                    string fifteen = null;
                    string eighteen = null;

                    StringBuilder sb = new StringBuilder();

                    if (perfume.ThreeMonths != 0)
                    {
                        three = $"▪ 3 ay x {perfume.ThreeMonths} azn";
                        sb.AppendLine(three);
                    }

                    if (perfume.SixMonths != 0)
                    {
                        six = $"▪ 6 ay x {perfume.SixMonths} azn";
                        sb.AppendLine(six);

                    }

                    if (perfume.NineMonths != 0)
                    {
                        nine = $"▪ 9 ay x {perfume.NineMonths} azn";
                        sb.AppendLine(nine);
                    }

                    if (perfume.TwelveMonths != 0)
                    {
                        twelve = $"▪ 12 ay x {perfume.TwelveMonths} azn";
                        sb.AppendLine(twelve);
                    }

                    if (perfume.FifteenMonths != 0)
                    {
                        fifteen = $"▪ 15 ay x {perfume.FifteenMonths} azn";
                        sb.AppendLine(fifteen);
                    }

                    if (perfume.EighteenMonths != 0)
                    {
                        eighteen = $"▪ 18 ay x {perfume.EighteenMonths} azn";
                        sb.AppendLine(eighteen);
                    }

                    //                    string main =
                    //$@"{three}
                    //{six}
                    //{nine}
                    //{twelve}
                    //{fifteen}
                    //{eighteen}";

                    if (perfume.IsTester)
                    {
                        perfume.Description =
                        @$"{_context.Brands.FirstOrDefault(b => b.Id == perfume.BrandId).Name} - {perfume.Name} ətirinin nağd satış qiyməti:

▪ {perfume.ML} ml - {perfume.Price} azn ({_context.Types.FirstOrDefault(b => b.Id == perfume.TypeId).Name}) TESTER
_________________________

İLKİN ÖDƏNİŞSİZ KREDiT:

{perfume.ML} ML TESTER ÜÇÜN ⬇️

{sb.ToString()}";
                    }
                    else
                    {
                        perfume.Description =
@$"{_context.Brands.FirstOrDefault(b => b.Id == perfume.BrandId).Name} - {perfume.Name} ətirinin nağd satış qiyməti:

▪ {perfume.ML} ml - {perfume.Price} azn ({_context.Types.FirstOrDefault(b => b.Id == perfume.TypeId).Name})
_________________________

İLKİN ÖDƏNİŞSİZ KREDiT:

{perfume.ML} ML ÜÇÜN ⬇️

{sb.ToString()}";
                    }

                    perfume.UpdatedDate = DateTime.UtcNow.AddHours(4);

                    _context.Update(perfume);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerfumeExists(perfume.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", perfume.BrandId);
            ViewData["TypeId"] = new SelectList(_context.Types, "Id", "Name", perfume.TypeId);
            return View(perfume);
        }

        // GET: Admin/AnswerSystem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfumes
                .Include(p => p.Brand)
                .Include(p => p.Type)
                .FirstOrDefaultAsync(m => m.Id == id && m.DeletedDate == null);
            if (perfume == null)
            {
                return NotFound();
            }

            ViewBag.Username = await _context.Users.FirstOrDefaultAsync(u => u.Id == User.GetUserId());

            return View(perfume);
        }

        // POST: Admin/AnswerSystem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perfume = await _context.Perfumes.FindAsync(id);
            perfume.DeletedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerfumeExists(int id)
        {
            return _context.Perfumes.Any(e => e.Id == id);
        }
    }
}
