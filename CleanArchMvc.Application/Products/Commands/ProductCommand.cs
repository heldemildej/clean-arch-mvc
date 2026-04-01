using CleanArchMvc.Application.DTOs;
using MediatR;

namespace CleanArchMvc.Application.Products.Commands
{
    // Command base para Product
    public abstract class ProductCommand : IRequest<ProductDTO>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Img { get; set; }
        public int CategoryId { get; set; }
    }
}