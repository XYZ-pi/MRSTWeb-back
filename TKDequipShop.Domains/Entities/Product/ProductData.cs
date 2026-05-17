using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Cart;
using TKDequipShop.Domains.Entities.Order;
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
        [InverseProperty("Product")]
        public List<CartItemData> CartItems { get; set; } = new List<CartItemData>();

        [InverseProperty("Product")]
        public List<OrderItemData> OrderItems { get; set; } = new List<OrderItemData>();
        [StringLength(500)]
        public string? Image { get; set; }
        public double RatingRate { get; set; } = 0;
        public int RatingCount { get; set; } = 0;
        [StringLength(50)]
        public string? Badge { get; set; }
    }
}
