using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKDequipShop.Domains.Models.Product
{
    public class ProductCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public string Category { get; set; }
        public string? Image { get; set; }
        public double RatingRate { get; set; } = 0;
        public int RatingCount { get; set; } = 0;
        public string? Badge { get; set; }

    }
}
