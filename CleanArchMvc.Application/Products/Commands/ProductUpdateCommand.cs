using MediatR;
using CleanArchMvc.Application.DTOs;

namespace CleanArchMvc.Application.Products.Commands
{
    public class ProductUpdateCommand : ProductCommand, IRequest<ProductDTO>
    {
        public int Id { get; set; }
    }
}