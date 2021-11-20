using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandlers
{
    //It doesn't touch our data layer directly
    //At compile time it will inject the repository
    //That's why we have seperated interfaces
    //So We can have multiple Repository types that ProductRepository can touch 
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public ProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            _productRepository.Add(product);

            return Task.FromResult(true);
        }
    }
}
