using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.DTOs;
using MediatR;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class ProductCreateCommandHandler
        : IRequestHandler<ProductCreateCommand, ProductDTO>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductCreateCommandHandler(
            IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(
                request.Name,
                request.Description,
                request.Price,
                request.Stock,
                request.Img
            );

            product.CategoryId = request.CategoryId;

            var createdProduct = await _productRepository.CreateAsync(product);

            return _mapper.Map<ProductDTO>(createdProduct);
        }
    }
}