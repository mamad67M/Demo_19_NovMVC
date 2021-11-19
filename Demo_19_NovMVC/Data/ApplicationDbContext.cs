using Demo_19_NovMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_19_NovMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions option): base(option)
        {

        }
        public DbSet<Produit> Produits { get; set; }
    }
}
