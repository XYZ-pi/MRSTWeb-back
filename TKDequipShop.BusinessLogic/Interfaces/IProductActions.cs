using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Models.Product;

namespace TKDequipShop.BusinessLogic.Interfaces
{
    public interface IProductActions
    {
        public List<ProductResponseDto> GetAllProductsAction();

        public ProductResponseDto CreateNewProductAction(ProductCreateDto _product);

        public ProductResponseDto UpdateProductAction(int id, ProductCreateDto _product);

        public bool DeleteProductAction(int id);

        public ProductResponseDto GetByIdProductAction(int id);

        public List<ProductResponseDto> GetByCategoryProductsAction(string _category);
    }
}
