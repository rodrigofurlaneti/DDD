using DDD.Application.Interface;
using DDD.Domian.Entities;
using DDD.Domian.Interfaces.Services;
namespace DDD.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _clientService;
        public ClientAppService(IClientService clientService)
            : base (clientService)
        {
            _clientService = clientService;
        }
    }
}
