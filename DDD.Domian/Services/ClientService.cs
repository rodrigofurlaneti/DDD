using DDD.Domian.Entities;
using DDD.Domian.Interfaces;
using DDD.Domian.Interfaces.Services;
namespace DDD.Domian.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository) 
            : base (clientRepository)
        {
            _clientRepository = clientRepository;
        }
    }
}
