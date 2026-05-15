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

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductCreateDto _product)
        {
            var _updatedProduct = _productActions.UpdateProductAction(id, _product);
            return Ok(_updatedProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var IsDeleted = _productActions.DeleteProductAction(id);
            if (!IsDeleted) return NotFound();
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var _product = _productActions.GetByIdProductAction(id);

            if (_product == null) return NotFound();

            return Ok(_product);
        }

        [HttpGet("{category}")]
        public IActionResult GetByCategory(string _category)
        {
            var _product = _productActions.GetByCategoryProductsAction(_category);

            if (_product == null) return NotFound();

            return Ok(_product);
        }
    }
}
