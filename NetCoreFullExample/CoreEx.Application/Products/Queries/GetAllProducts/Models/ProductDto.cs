using System;

namespace CoreEx.Application.Products.Queries.GetAllProducts.Models
{
    public class ProductDto
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
