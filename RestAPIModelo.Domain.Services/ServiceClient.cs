using RestAPIModelo.Domain.Core.Interfaces.Repositorys;
using RestAPIModelo.Domain.Core.Interfaces.Services;
using RestAPIModelo.Domain.Entitys;

namespace RestAPIModelo.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient)
            : base(repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }
    }
}