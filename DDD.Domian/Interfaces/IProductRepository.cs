using DDD.Domian.Entities;
using System.Collections.Generic;
namespace DDD.Domian.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
