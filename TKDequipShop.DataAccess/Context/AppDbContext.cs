using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Cart;
using TKDequipShop.Domains.Entities.Product;
using TKDequipShop.Domains.Entities.User;
using TKDequipShop.Domains.Entities.Order;

namespace TKDequipShop.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductData> ProductDatas { get; set; }
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<OrderData> OrderDatas { get; set; }
        public DbSet<OrderItemData> OrderItemDatas { get; set; }
        public DbSet<CartData> CartDatas { get; set; }
        public DbSet<CartItemData> CartItemDatas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbSession.ConnectionString);
        }
    }
}
