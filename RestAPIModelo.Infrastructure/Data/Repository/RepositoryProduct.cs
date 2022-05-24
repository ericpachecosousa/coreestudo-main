using RestAPIModelo.Domain.Core.Interfaces.Repositorys;
using RestAPIModelo.Domain.Entitys;

namespace RestAPIModelo.Infrastructure.Data.Repository
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduct(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}