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
using Projet_Exam_ASP.NetCore.Areas.Identity.Data;
using Projet_Exam_ASP.NetCore.Data;
using Projet_Exam_ASP.NetCore.Models;

namespace Projet_Exam_ASP.NetCore.Controllers
{
    public class BoutiquesController : BaseController
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        public BoutiquesController(AppDbContext context, IWebHostEnvironment hostEnvironment) : base(context) {
            _hostEnvironment = hostEnvironment;
        }


        // GET: Boutiques
        public async Task<IActionResult> Index()
        {
            ClaimsPrincipal currentUser = this.User;
            List<string> images = new List<string>();
            List<string> nomsPropriétaires = new List<string>();
            var appDbContext = _context.Boutiques.Include(b => b.Image);
            foreach(var boutique in appDbContext) 
            {
                images.Add((_context.Images.Find(boutique.ImageId)).Nom);
                var prop = _context.Users.Where(u => u.BoutiqueId == boutique.Id).First();
                nomsPropriétaires.Add(prop.Prenom + " " + prop.Nom);
            }
            ViewBag.images = images;
            ViewBag.nomsPropriétaires = nomsPropriétaires;
            return View(await appDbContext.ToListAsync());
        }

        // GET: Boutiques/Details/5
        public async Task<IActionResult> Details(int? id)
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
            var prop = _context.Users.Where(u => u.BoutiqueId == boutique.Id).First();
            ViewBag.nomPropriétaire = prop.Prenom + " " + prop.Nom;
            ViewBag.image= (_context.Images.Find(boutique.ImageId)).Nom;


            ClaimsPrincipal currentUser = this.User;
            AppUser CurrentUser = null;
            if (User.Identity.IsAuthenticated)
            {
                var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
                CurrentUser = _context.Users.Find(currentUserID);
            }

            var offres = _context.Offres.Where(o => o.AppUserId == prop.Id).ToList();
            List <Offre> offresSpéciales = offres.Where(o => o.reduction > 0).OrderByDescending(o => o.reduction).Take(12).ToList();
            List<Image> imagesOffresSpéciales = new List<Image>();
            List<Boolean> isFavoriList = new List<bool>();

            foreach (Offre o in offresSpéciales)
            {
                if (_context.Images.Where(i => i.OffreId == o.Id).ToList().Count() != 0)
                    imagesOffresSpéciales.Add(_context.Images.Where(i => i.OffreId == o.Id).ToList().First());
                else
                    imagesOffresSpéciales.Add((new Image { Nom = "Offre_Icone_Par_Defaut.png" }));
                if (User.Identity.IsAuthenticated)
                {
                    if (_context.Favoris.Where(f => f.AppUserId == CurrentUser.Id && o.Id == f.OffreId).Count() == 0)
                        isFavoriList.Add(false);
                    else
                        isFavoriList.Add(true);
                }
            }
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.isFavoriList_OffresSpéciales = isFavoriList;
            }
            ViewBag.imagesOffresSpéciales = imagesOffresSpéciales;
            ViewBag.OffresSpéciales = offresSpéciales;
            ViewBag.OffresSpéciales_Count = offresSpéciales.Count();




            Dictionary<Offre, int> NbFavorisParOffre = new Dictionary<Offre, int>();
            List<Image> imagesMeilleuresOffres = new List<Image>();
            List<Boolean> isFavoriList_MeilleuresOffres = new List<bool>();
            foreach (var offre in offres)
                NbFavorisParOffre.Add(offre, _context.Favoris.Where(f => f.Offre == offre).Count());
            List<int> nombreFavories = new List<int>();
            List<Offre> MeilleuresOffres = new List<Offre>();
            for (int i = 0; i < 16; i++)
            {
                if (NbFavorisParOffre.Count() != 0)
                {
                    Offre offre = NbFavorisParOffre.FindFirstKeyByValue(NbFavorisParOffre.Values.Max());
                    MeilleuresOffres.Add(offre);
                    nombreFavories.Add(NbFavorisParOffre[offre]);
                    if (_context.Images.Where(i => i.OffreId == offre.Id).ToList().Count() != 0)
                        imagesMeilleuresOffres.Add(_context.Images.Where(i => i.OffreId == offre.Id).ToList().First());
                    else
                        imagesMeilleuresOffres.Add((new Image { Nom = "Offre_Icone_Par_Defaut.png" }));
                    NbFavorisParOffre.Remove(offre);
                    if (User.Identity.IsAuthenticated)
                    {
                        if (_context.Favoris.Where(f => f.AppUserId == CurrentUser.Id && offre.Id == f.OffreId).Count() == 0)
                            isFavoriList_MeilleuresOffres.Add(false);
                        else
                            isFavoriList_MeilleuresOffres.Add(true);
                    }
                }
                else break;
            }
            ViewBag.nombreFavories = nombreFavories;
            ViewBag.MeilleuresOffres = MeilleuresOffres;
            ViewBag.imagesMeilleuresOffres = imagesMeilleuresOffres;
            ViewBag.MeilleuresOffres_Count = MeilleuresOffres.Count();
            ViewBag.isFavoriList_MeilleuresOffres = isFavoriList_MeilleuresOffres;



            List<Offre> NouvellesOffres = offres.OrderByDescending(f => f.Date_Dépot).Take(16).ToList();
            List<bool> isFavoriList_Nouveauté = new List<bool>();
            List<Image> imagesNouveauté = new List<Image>();
            foreach (Offre offre in offres)
            {
                if (User.Identity.IsAuthenticated)
                {
                    if (_context.Favoris.Where(f => f.AppUserId == CurrentUser.Id && offre.Id == f.OffreId).Count() == 0)
                        isFavoriList_Nouveauté.Add(false);
                    else
                        isFavoriList_Nouveauté.Add(true);
                }
                if (_context.Images.Where(i => i.OffreId == offre.Id).ToList().Count() != 0)
                    imagesNouveauté.Add(_context.Images.Where(i => i.OffreId == offre.Id).ToList().First());
                else
                    imagesNouveauté.Add((new Image { Nom = "Offre_Icone_Par_Defaut.png" }));
            }
            ViewBag.Nouveauté = NouvellesOffres;
            ViewBag.imagesNouveauté = imagesNouveauté;
            ViewBag.Nouveauté_Count = NouvellesOffres.Count();
            ViewBag.isFavoriList_Nouveauté = isFavoriList_Nouveauté;

            
            ViewBag.Propriétaire = prop;
            
            return View(boutique);
        }
        public async Task<IActionResult> Statitstics(int? id)
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
            var propriétaire = _context.Users.Where(u => u.BoutiqueId == id).ToList().First();
            var offres = _context.Offres.Where(o => o.AppUserId == propriétaire.Id).ToList();
            int Nombrefavoris = 0;
            List<string> clientsId = new List<string>();
            foreach(Offre offre in offres)
            {
                var favoris = _context.Favoris.Where(f => f.OffreId == offre.Id).ToList();
                Nombrefavoris += favoris.Count();
                foreach (var f in favoris)
                {
                    if(!clientsId.Contains(f.AppUserId))
                    {
                        clientsId.Add(f.AppUserId);
                    }
                }
            }
            ViewBag.Boutique = boutique;
            ViewBag.nombreOffres = offres.Count();
            ViewBag.nombreClients = clientsId.Count();
            ViewBag.nombreFavoris = Nombrefavoris;
            ViewBag.nombrePostDuMois = _context.Offres.Where(o => o.AppUserId == propriétaire.Id && o.Date_Dépot.Month == DateTime.Now.Month).ToList().Count();
            return View();
            

        }

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
