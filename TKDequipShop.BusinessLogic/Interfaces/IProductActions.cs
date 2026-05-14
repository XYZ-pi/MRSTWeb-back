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
    }
}
