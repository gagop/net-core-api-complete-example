using System.Collections.Generic;

namespace CoreEx.Application.Products.Queries.GetAllProducts.Models
{
    public class ProductsListDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
