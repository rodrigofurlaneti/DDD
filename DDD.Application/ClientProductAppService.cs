using DDD.Application.Interface;
using DDD.Domian.Entities;
using DDD.Domian.Interfaces.Services;
namespace DDD.Application
{
    public class ClientProductAppService : AppServiceBase<ClientProduct>, IClientProductAppService
    {
        private readonly IClient_ProductService _clientproductService;
        public ClientProductAppService(IClient_ProductService clientproductService)
            : base(clientproductService)
        {
            _clientproductService = clientproductService;
        }
    }
}
