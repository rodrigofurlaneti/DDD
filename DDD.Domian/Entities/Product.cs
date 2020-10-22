using System.Collections.Generic;

namespace DDD.Domian.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Available { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
