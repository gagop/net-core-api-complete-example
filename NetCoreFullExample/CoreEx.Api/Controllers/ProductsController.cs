
using CoreEx.Application.Products.Queries.GetAllProducts;
using CoreEx.Application.Products.Queries.GetAllProducts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreExApi.Controllers
{
    [Route("api/products")]
    public class ProductsController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductsListDto>> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllProductsQuery()));
        }
    }
}