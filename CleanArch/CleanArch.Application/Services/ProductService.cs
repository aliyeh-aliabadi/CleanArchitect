﻿using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public ProductService(IProductRepository productRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _productRepository = productRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        //Use MediateR
        public void CreateProduct(ProductViewModel productViewModel)
        {
            var createProductCommand = new CreateProductCommand(
                productViewModel.Name,
                productViewModel.Description,
                productViewModel.ImageUrl
                );

            _bus.SendCommand(createProductCommand);
        }

        ProductViewModel IProductService.GetProducts()
        {
            return new ProductViewModel()
            {
                Products = _productRepository.GetProducts()
            };
        }
    }
}
