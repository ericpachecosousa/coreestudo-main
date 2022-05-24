using RestAPIModelo.Domain.Core.Interfaces.Repositorys;
using RestAPIModelo.Domain.Entitys;

namespace RestAPIModelo.Infrastructure.Data.Repository
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;

        public RepositoryClient(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}