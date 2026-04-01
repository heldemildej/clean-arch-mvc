using CleanArchMvc.Application.DTOs;
using MediatR;

namespace CleanArchMvc.Application.Product.Queries
{
    public class GetProductByIdQuery : IRequest<ProductDTO>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}