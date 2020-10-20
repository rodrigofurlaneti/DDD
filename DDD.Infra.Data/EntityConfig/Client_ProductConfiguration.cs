using DDD.Domian.Entities;
using System.Data.Entity.ModelConfiguration;
namespace DDD.Infra.Data.EntityConfig
{
    public class Client_ProductConfiguration : EntityTypeConfiguration<Client_Product>
    {
        public Client_ProductConfiguration()
        {
            HasKey(p => p.Client_ProductId);
            HasRequired(p => p.Client).WithMany().HasForeignKey(p => p.ClientId);
            HasRequired(p => p.Product).WithMany().HasForeignKey(p => p.ProductId);
        }

    }
}
