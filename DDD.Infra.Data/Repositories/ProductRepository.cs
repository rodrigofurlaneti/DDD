using DDD.Domian.Entities;
using DDD.Domian.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> SearchByName(string name)
        {
            return _context.Products.Where(p => p.Name == name);
        }
    }
}
