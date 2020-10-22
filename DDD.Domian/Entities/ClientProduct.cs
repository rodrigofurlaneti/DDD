namespace DDD.Domian.Entities
{
    public class ClientProduct
    {
        public int ClientProductId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public virtual Client Clients { get; set; }
        public virtual Product Products { get; set; }
    }
}
