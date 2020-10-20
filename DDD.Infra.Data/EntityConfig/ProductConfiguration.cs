using System.Data.Entity.ModelConfiguration;
using DDD.Domian.Entities;
namespace DDD.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId);
            Property(c => c.Name).IsRequired().HasMaxLength(250);
            Property(c => c.Value).IsRequired();
        }
    }
}
