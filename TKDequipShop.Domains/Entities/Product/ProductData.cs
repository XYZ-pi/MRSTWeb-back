using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Refs;

namespace TKDequipShop.Domains.Entities.Product
{
    public class ProductData : SharedFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Category { get; set; }
    }
}
