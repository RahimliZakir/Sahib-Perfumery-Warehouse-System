using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sahib.az.WebApplicationUI.Models.DataContext;
using sahib.az.WebApplicationUI.Models.Entity;

namespace sahib.az.WebApplicationUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LogosController : Controller
    {
        private readonly SahibDbContext _context;
        private readonly IWebHostEnvironment env;

        public LogosController(SahibDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this.env = env;
        }

        // GET: Admin/Logos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Logos.Where(l => l.DeletedDate == null).ToListAsync());
        }

        // GET: Admin/Logos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logo = await _context.Logos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logo == null)
            {
                return NotFound();
            }

            return View(logo);
        }

        // GET: Admin/Logos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Logos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath")] Logo logo, IFormFile file)
        {
            if (file == null)
            {
                ModelState.AddModelError("", "Şəkil seçin!");
            }
            else if (file != null)
            {

                string ext = Path.GetExtension(file.FileName);
                string filename = $"logo-{Guid.NewGuid().ToString().Replace("-", "")}{ext}";
                string fullpath = Path.Combine(env.WebRootPath, "uploads", "logos", filename);

                using (var fs = new FileStream(fullpath, FileMode.Create, FileAccess.Write))
                {
                    file.CopyTo(fs);
                }

                try
                {
                    logo.ImagePath = filename;
                    _context.Add(logo);
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

            return View(logo);
        }

        // GET: Admin/Logos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logo = await _context.Logos.FindAsync(id);
            if (logo == null)
            {
                return NotFound();
            }
            return View(logo);
        }

        // POST: Admin/Logos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Temp")] Logo logo, IFormFile file)
        {
            if (id != logo.Id)
            {
                return NotFound();
            }

            var entity = _context.Logos.AsNoTracking().FirstOrDefault(l => l.Id == id);

            string currentpath = null;
            string fullpath = null;

            if (file == null && !string.IsNullOrWhiteSpace(logo.Temp))
            {
                logo.ImagePath = entity.ImagePath;
            }
            else if (file == null)
            {
                currentpath = Path.Combine(env.WebRootPath, "uploads", "logos", entity.ImagePath);

            }
            else if (file != null)
            {
                var ext = Path.GetExtension(file.FileName);
                string filename = $"logo-{Guid.NewGuid().ToString().Replace("-", "")}{ext}";
                fullpath = Path.Combine(env.WebRootPath, "uploads", "logos", filename);

                using (var fs = new FileStream(fullpath, FileMode.Create, FileAccess.Write))
                {
                    file.CopyTo(fs);
                }

                logo.ImagePath = filename;
            }

            try
            {
                logo.UpdatedDate = DateTime.UtcNow.AddHours(4);
                _context.Update(logo);
                await _context.SaveChangesAsync();

                if (System.IO.File.Exists(currentpath) && !string.IsNullOrWhiteSpace(currentpath))
                {
                    System.IO.File.Delete(currentpath);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (System.IO.File.Exists(fullpath) && !string.IsNullOrWhiteSpace(fullpath))
                {
                    System.IO.File.Delete(fullpath);
                }

            }

            return View(logo);
        }

        // GET: Admin/Logos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logo = await _context.Logos
                .FirstOrDefaultAsync(m => m.Id == id && m.DeletedDate == null);
            if (logo == null)
            {
                return NotFound();
            }

            return View(logo);
        }

        // POST: Admin/Logos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var logo = await _context.Logos.FindAsync(id);
            logo.DeletedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LogoExists(int id)
        {
            return _context.Logos.Any(e => e.Id == id);
        }
    }
}
