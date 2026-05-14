using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKDequipShop.BusinessLogic;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.Domains.Models.Product;

namespace TKDequip.API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductActions _productActions;
        public ProductController()
        {
            var _bl = new TKDequipShop.BusinessLogic.BusinessLogic();
            _productActions = _bl.GetProductActions();
        }

        [HttpGet("all")]
        public IActionResult GetAllProducts()
        {
            var _products = _productActions.GetAllProductsAction();
            return Ok(_products);
        }
        [HttpPost]
        public IActionResult CreateNewProduct(ProductCreateDto _product)
        {
            var _newProduct = _productActions.CreateNewProductAction(_product);
            return Created($"/api/product/{_newProduct.Id}", _newProduct);
        }
    }
}
