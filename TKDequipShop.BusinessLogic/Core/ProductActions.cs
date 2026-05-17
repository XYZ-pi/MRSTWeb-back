using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TKDequipShop.DataAccess.Context;
using TKDequipShop.Domains.Entities.Product;
using TKDequipShop.Domains.Models.Product;

namespace TKDequipShop.BusinessLogic.Core
{
    public class ProductActions
    {
        protected AppDbContext _db = new AppDbContext();

        public List<ProductData> ExecuteGetAllProductsAction()
        {
            return _db.ProductDatas.ToList();
        }

        public ProductData ExecuteCreateNewProductsAction(ProductCreateDto _product)
        {
            ProductData newProduct = new ProductData()
            {
                Name = _product.Name,
                Description = _product.Description,
                Price = _product.Price,
                Category = _product.Category,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _db.ProductDatas.Add(newProduct);
            _db.SaveChanges();
            return newProduct;
        }

        public ProductData ExecuteUpdateProductAction(int id, ProductCreateDto _product)
        {
            var product = _db.ProductDatas.FirstOrDefault(p => p.Id == id);
            if (product == null) return null;
            product.Name = _product.Name;
            product.Description = _product.Description;
            product.Price = _product.Price;
            product.UpdatedAt = DateTime.Now;
            _db.SaveChanges();
            return product;
        }

        public bool ExecuteDeleteProductAction(int id)
        {
            var product = _db.ProductDatas.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;
            _db.ProductDatas.Remove(product);
            _db.SaveChanges();
            return true;
        }

        public ProductData ExecuteGetByIdProductAction(int id)
        {
            return _db.ProductDatas.FirstOrDefault(p => p.Id == id);
        }

        public List<ProductData> ExecuteGetByCategoryProductsAction(string category)
        {
            return _db.ProductDatas
                .Where(p => p.Category.Contains(category))
                .ToList();
        }

        public void ExecuteSeedProducts()
        {
            if (_db.ProductDatas.Any()) return; // если товары уже есть - не добавляем

            var products = new List<ProductData>
    {
        new ProductData { Name = "Добок TUSAH EVO UNIFORM", Price = 3999, Category = "clothing", Description = "Официальный добок для соревнований по стандарту WT.", Image = "/dobok evo.png", RatingRate = 4.8, RatingCount = 134, Badge = "Хит" },
        new ProductData { Name = "Добок TUSAH EZ FIT LITE UNIFORM", Price = 1000, Category = "clothing", Description = "Удобный добок для ежедневных тренировок.", Image = "/dobok ez fit.png", RatingRate = 4.5, RatingCount = 89 },
        new ProductData { Name = "Добок STARTER", Price = 600, Category = "clothing", Description = "Удобный добок для тренировок. Для самых маленьких.", Image = "/starter 600.png", RatingRate = 4.3, RatingCount = 56 },
        new ProductData { Name = "Добок STARTER", Price = 650, Category = "clothing", Description = "Удобный детский добок для ежедневных тренировок.", Image = "/starter 650.png", RatingRate = 4.4, RatingCount = 56 },
        new ProductData { Name = "Степки TUSAH CLASSIC SHOES", Price = 750, Category = "shoes", Description = "Классические степки с нескользящей подошвой.", Image = "/classic.png", RatingRate = 4.7, RatingCount = 203, Badge = "Топ" },
        new ProductData { Name = "Степки EZ-FIT SHOES", Price = 699, Category = "shoes", Description = "Профессиональные степки с нескользящей подошвой.", Image = "/stepki.png", RatingRate = 4.9, RatingCount = 312, Badge = "Новинка" },
        new ProductData { Name = "Накладки на ноги", Price = 580, Category = "protection", Description = "Накладки на ноги. Совместимы со всеми системами WT.", Image = "/nogi.png", RatingRate = 4.8, RatingCount = 67 },
        new ProductData { Name = "Накладки на руки", Price = 500, Category = "protection", Description = "Накладки на руки. Совместимы со всеми системами WT.", Image = "/ruki.png", RatingRate = 4.6, RatingCount = 143 },
        new ProductData { Name = "Защитный шлем", Price = 800, Category = "protection", Description = "Защитный шлем. Плотный пенополиуретан.", Image = "/shlem.png", RatingRate = 4.7, RatingCount = 88 },
        new ProductData { Name = "Красный защитный шлем", Price = 800, Category = "protection", Description = "Красный защитный шлем. Плотный пенополиуретан.", Image = "/shlem krasnii.png", RatingRate = 4.7, RatingCount = 88 },
        new ProductData { Name = "Перчатки", Price = 400, Category = "protection", Description = "Перчатки для защиты рук.", Image = "/manusi.png", RatingRate = 4.7, RatingCount = 88 },
        new ProductData { Name = "Футы тренировочные", Price = 500, Category = "protection", Description = "Футы тренировочные.", Image = "/futi.png", RatingRate = 4.7, RatingCount = 88 },
        new ProductData { Name = "Протектор", Price = 900, Category = "protection", Description = "Протектор для тренировок.", Image = "/vesta.png", RatingRate = 4.7, RatingCount = 88 },
        new ProductData { Name = "Лапа двойная", Price = 600, Category = "equipment", Description = "Профессиональные лапы для отработки ударов.", Image = "/lapaa.png", RatingRate = 4.8, RatingCount = 176, Badge = "Хит" },
        new ProductData { Name = "Макивара", Price = 1250, Category = "equipment", Description = "Тренажёр для отработки ударной техники.", Image = "/lapaaa.png", RatingRate = 4.5, RatingCount = 54 },
        new ProductData { Name = "Макивара маленькая", Price = 940, Category = "equipment", Description = "Тренажёр для отработки ударной техники.", Image = "/lapa.png", RatingRate = 4.3, RatingCount = 231 },
        new ProductData { Name = "Тигр игрушка", Price = 450, Category = "other", Description = "Игрушка в виде тигра.", Image = "/tigr.png", RatingRate = 4.7, RatingCount = 98 },
        new ProductData { Name = "Медведь игрушка", Price = 450, Category = "other", Description = "Игрушка в виде медведя.", Image = "/medved.png", RatingRate = 4.4, RatingCount = 201 },
    };

            _db.ProductDatas.AddRange(products);
            _db.SaveChanges();
        }

    }
}