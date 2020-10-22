using DDD.Domian.Entities;
using DDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
namespace DDD.Infra.Data.Context
{
    public class ContextDDD : DbContext
    {
        public ContextDDD() 
            : base ("dbConnection") { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ClientProduct> ClientProduct { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Setar padrões para quando o Entity escrever o banco
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Quando a propriedade for nomo + Id determine ela como chave primária
            //modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());

            //Quando não setar o valor na classe, sempre string vai ser VARCHAR com tamanho de 100 caracteres
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("VARCHAR"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //Chama a configuração da entidade para escrever o banco conforme orientado
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ClientProductConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries().Where(item => item.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if(item.State == EntityState.Added)
                {
                    item.Property("RegistrationDate").CurrentValue = DateTime.Now;
                }
                if (item.State == EntityState.Modified)
                {
                    item.Property("RegistrationDate").IsModified = false; 
                }
            }
            return base.SaveChanges();
        }
    }

}
