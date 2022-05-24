using RestAPIModelo.Domain.Core.Interfaces.Repositorys;
using RestAPIModelo.Domain.Core.Interfaces.Services;
using RestAPIModelo.Domain.Entitys;

namespace RestAPIModelo.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}