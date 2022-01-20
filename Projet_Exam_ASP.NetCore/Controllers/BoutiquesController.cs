using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projet_Exam_ASP.NetCore.Data;
using Projet_Exam_ASP.NetCore.Models;

namespace Projet_Exam_ASP.NetCore.Controllers
{
    public class BoutiquesController : BaseController
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        public BoutiquesController(AppDbContext context) : base(context) { }


        // GET: Boutiques
        public async Task<IActionResult> Index()
        {
            ClaimsPrincipal currentUser = this.User;
            
            var appDbContext = _context.Boutiques.Include(b => b.Image);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Boutiques/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var boutique = await _context.Boutiques
                 .Include(b => b.Image)
                 .FirstOrDefaultAsync(m => m.Id == id);
            if (boutique == null)
            {
                return NotFound();
            }
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewBag.currentUser = _context.Users.Find(currentUserID);

            ViewBag.OffresSpéciales = _context.Offres.Where(o => o.reduction < 0&&o.AppUser.Boutique==boutique).OrderBy(o => o.reduction).Take(10).ToList();

            Dictionary<Offre, int> NbFavorisParOffre = new Dictionary<Offre, int>();
            foreach (var offre in _context.Offres.Where(o=> o.AppUser.Boutique == boutique).ToList())
                NbFavorisParOffre.Add(offre, _context.Favoris.Where(f => f.Offre == offre).Count());
            List<Offre> MeilleuresOffres = new List<Offre>();
            for (int i = 0; i < 10; i++)
            {
                if (NbFavorisParOffre.Count() != 0)
                {
                    MeilleuresOffres.Add(NbFavorisParOffre.FindFirstKeyByValue(NbFavorisParOffre.Values.Max()));
                    NbFavorisParOffre.Remove(NbFavorisParOffre.FindFirstKeyByValue(NbFavorisParOffre.Values.Max()));
                }
            }
            ViewBag.MeilleursOffres = MeilleuresOffres;
            ViewBag.Nouveauté = _context.Offres.Where(o => o.AppUser.Boutique == boutique).OrderByDescending(f => f.Date_Dépot).ToList();

            if (id == null)
            {
                return NotFound();
            }

            
            return View(boutique);
        }

        // GET: Boutiques/Create
        

        // GET: Boutiques/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boutique = await _context.Boutiques.FindAsync(id);
            if (boutique == null)
            {
                return NotFound();
            }
            ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Id", boutique.ImageId);
            return View(boutique);
        }

        // POST: Boutiques/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Description,Telephone,Ville,site,Adresse,ImageId")] Boutique boutique,IFormFile image)
        {
            if (id != boutique.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //pour ajouter l'image dans le dossier Images------------
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(image.FileName);
                string fileExtention = Path.GetExtension(image.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff");
                string path = Path.Combine(wwwRootPath + "/images/Boutiques" + fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }
                //----------------------------------------------------------
                //pour ajouter l'image dans la table image de la base de données--------------
                Image img = new Image { Nom = fileName };
                _context.Images.Add(img);
                await _context.SaveChangesAsync();
                //----------------------------------------------------------
                boutique.Image=img;
                try
                {
                    _context.Update(boutique);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoutiqueExists(boutique.Id))
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
            ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Id", boutique.ImageId);
            return View(boutique);
        }

        // GET: Boutiques/Delete/5
        

        private bool BoutiqueExists(int id)
        {
            return _context.Boutiques.Any(e => e.Id == id);
        }
        // GET: Offres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boutique = await _context.Boutiques
                 .Include(b => b.Image)
                 .FirstOrDefaultAsync(m => m.Id == id);
            if (boutique == null)
            {
                return NotFound();
            }

            return View(boutique);
        }

        // POST: Offres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boutique = await _context.Boutiques.FindAsync(id);
            _context.Boutiques.Remove(boutique);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
