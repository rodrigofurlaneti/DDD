﻿using DDD.Application.Interface;
using DDD.Domian.Entities;
using DDD.Domian.Interfaces.Services;
namespace DDD.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;
        public ProductAppService(IProductService productService)
            : base (productService)
        {
            _productService = productService;
        }
    }
}
