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
    }
}
