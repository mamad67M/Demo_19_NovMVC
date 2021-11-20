using Demo_19_NovMVC.Data;
using Demo_19_NovMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_19_NovMVC.Controllers
{
    public class ProduitController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProduitController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Produit> ListProd = _db.Produits;
            return View(ListProd);
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produit p)
        {
            if (ModelState.IsValid)
            {
                _db.Produits.Add(p);
                _db.SaveChanges();
                TempData["success"] = " le produit a été créé avec succes";
                return RedirectToAction("Index");
            }

            return View(p);
        }

        // Edit
        [HttpGet]
        public IActionResult Edit(int ? id)
        {
            if (id ==0 || id ==null)
            {
                return NotFound();
            }
            Produit p = _db.Produits.SingleOrDefault(p => p.ProduitID ==id);
            if (p ==null)
            {
                return NotFound();

            }
            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(Produit p)
        {
            if (ModelState.IsValid)
            {
                _db.Produits.Update(p);
                _db.SaveChanges();
                TempData["success"] = " le produit a été modifié avec succes";

                return RedirectToAction("Index");
            }

            return View(p);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            Produit p = _db.Produits.SingleOrDefault(p => p.ProduitID == id);
            if (p == null)
            {
                return NotFound();

            }
            return View(p);
        }

        [HttpPost]
        public IActionResult Delete(Produit p)
        {
            var deletedP = _db.Produits.Find(p.ProduitID);

            if (deletedP !=null)
            {
                _db.Produits.Remove(deletedP);
                _db.SaveChanges();
                TempData["success"] = " le produit a été supprimé avec succes";

                return RedirectToAction("Index");
            }

            return View(deletedP);
        }
    }
}
