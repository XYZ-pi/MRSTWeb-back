using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Product;
using TKDequipShop.Domains.Models.Product;

namespace TKDequipShop.BusinessLogic.Core
{
    public class ProductActions
    {
        static List<ProductData> products = new List<ProductData>();
        static int _nextId = 1;
        public List<ProductData> ExecuteGetAllProductsAction()
        {
            return products;
        }

        public ProductData ExecuteCreateNewProductsAction(ProductCreateDto _product)
        {
            ProductData newProduct = new ProductData()
            {
                Id = _nextId++,
                Name = _product.Name,
                Description = _product.Description,
                Price = _product.Price,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            products.Add(newProduct);

            return newProduct;
        }
    }
}
