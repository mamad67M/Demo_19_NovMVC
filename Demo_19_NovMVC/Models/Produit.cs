using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_19_NovMVC.Models
{
  [Table("PRODUIT")]
    public class Produit
    {
         [Key]
        public int ProduitID { get; set; }
        [Required]
        [MinLength(10), MaxLength(30)]
        public string Description { get; set; }
        [Required]
        [Range(100, 2000)]
        public double Prix { get; set; }
    }
}
