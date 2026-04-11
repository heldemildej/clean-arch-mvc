using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.DTOs;
using MediatR;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class ProductUpdateCommandHandler : IRequestHandler<ProductUpdateCommand, ProductDTO>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductUpdateCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if (product == null)
                throw new ApplicationException("Product could not be found");

            product.Update(
                request.Name,
                request.Description,
                request.Price,
                request.Stock,
                request.Img
            );

            product.CategoryId = request.CategoryId;

            var result = await _productRepository.UpdateAsync(product);

            return _mapper.Map<ProductDTO>(result);
        }
    }
}