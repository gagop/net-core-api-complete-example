using System.Collections.Generic;

namespace CoreEx.Application.Products.Queries.GetAllProducts.Models
{
    public class ProductsListDto
    {
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
