using DDD.Domian.Entities;
using DDD.Domian.Interfaces;
using DDD.Domian.Interfaces.Services;
using System.Collections.Generic;

namespace DDD.Domian.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> SearchByName(string name)
        {
            return _productRepository.SearchByName(name);
        }
    }
}
