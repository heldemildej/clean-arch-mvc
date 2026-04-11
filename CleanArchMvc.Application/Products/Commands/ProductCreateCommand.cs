using CleanArchMvc.Application.DTOs;
using MediatR;

namespace CleanArchMvc.Application.Products.Commands
{
    public class ProductCreateCommand : ProductCommand, IRequest<ProductDTO>
    {
    }
}