using DDD.Domian.Entities;
using DDD.Domian.Interfaces;
using DDD.Domian.Interfaces.Services;
namespace DDD.Domian.Services
{
    public class Client_ProductService : ServiceBase<ClientProduct>, IClient_ProductService
    {
        private readonly IClient_ProductRepository _client_productRepository;

        public Client_ProductService(IClient_ProductRepository client_productRepository)
            : base (client_productRepository)
        {
            _client_productRepository = client_productRepository;
        }
    }
}
