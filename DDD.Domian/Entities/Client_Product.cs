using System.Collections.Generic;
namespace DDD.Domian.Entities
{
    public class Client_Product
    {
        public int Client_ProductId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
    }
}
