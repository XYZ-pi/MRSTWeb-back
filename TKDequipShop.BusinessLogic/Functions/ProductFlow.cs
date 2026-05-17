using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.BusinessLogic.Core;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.Product;

namespace TKDequipShop.BusinessLogic.Functions
{
    public class ProductFlow : ProductActions, IProductActions
    {
        public void SeedProducts()
        {
            ExecuteSeedProducts();
        }
        public List<ProductResponseDto> GetAllProductsAction()
        {
            var products = ExecuteGetAllProductsAction();
            List<ProductResponseDto> productsDto = new List<ProductResponseDto>();

            foreach (var product in products)
            {
                var productRespDto = new ProductResponseDto()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    Category = product.Category,
                    Image = product.Image,
                    RatingRate = product.RatingRate,
                    RatingCount = product.RatingCount,
                    Badge = product.Badge,
                };
                productsDto.Add(productRespDto);

            }
            return productsDto;
        }

        public ProductResponseDto CreateNewProductAction(ProductCreateDto _product)
        {
            var newProduct = ExecuteCreateNewProductsAction(_product);

            ProductResponseDto newProductDto = new ProductResponseDto()
            {
                Id = newProduct.Id,
                Name = newProduct.Name,
                Price = newProduct.Price,
                Description = newProduct.Description,
                Category = newProduct.Category,
                Image = newProduct.Image,
                RatingRate = newProduct.RatingRate,
                RatingCount = newProduct.RatingCount,
                Badge = newProduct.Badge,
            };

            return newProductDto;
        }

        public ProductResponseDto UpdateProductAction(int id, ProductCreateDto _product)
        {
            var updatedProduct = ExecuteUpdateProductAction(id, _product);

            ProductResponseDto updatedProductDto = new ProductResponseDto()
            {
                Id = updatedProduct.Id,
                Name = updatedProduct.Name,
                Price = updatedProduct.Price,
                Description = updatedProduct.Description,
                Category = updatedProduct.Category,
                Image = updatedProduct.Image,
                RatingRate = updatedProduct.RatingRate,
                RatingCount = updatedProduct.RatingCount,
                Badge = updatedProduct.Badge,
            };

            return updatedProductDto;
        }

        public bool DeleteProductAction(int id)
        {

            return ExecuteDeleteProductAction(id);
        }

        public ProductResponseDto GetByIdProductAction(int id)
        {
            var foundProduct = ExecuteGetByIdProductAction(id);

            if (foundProduct == null) return null;

            ProductResponseDto foundProductDto = new ProductResponseDto()
            {
                Id = foundProduct.Id,
                Name = foundProduct.Name,
                Price = foundProduct.Price,
                Description = foundProduct.Description,
                Category = foundProduct.Category,
                Image = foundProduct.Image,
                RatingRate = foundProduct.RatingRate,
                RatingCount = foundProduct.RatingCount,
                Badge = foundProduct.Badge,
            };

            return foundProductDto;
        }

        public List<ProductResponseDto> GetByCategoryProductsAction(string _category)
        {
            var products = ExecuteGetByCategoryProductsAction(_category);
            List<ProductResponseDto> productsDto = new List<ProductResponseDto>();
            foreach (var product in products)
            {
                var productRespDto = new ProductResponseDto()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    Category = product.Category,
                    Image = product.Image,
                    RatingRate = product.RatingRate,
                    RatingCount = product.RatingCount,
                    Badge = product.Badge,
                };
                productsDto.Add(productRespDto);
            }
            return productsDto;
        }
    }
}
