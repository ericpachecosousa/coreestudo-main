using Autofac;
using RestAPIModelo.Application;
using RestAPIModelo.Application.Interfaces;
using RestAPIModelo.Application.Interfaces.Mappers;
using RestAPIModelo.Application.Mappers;
using RestAPIModelo.Domain.Core.Interfaces.Repositorys;
using RestAPIModelo.Domain.Core.Interfaces.Services;
using RestAPIModelo.Domain.Services;
using RestAPIModelo.Infrastructure.Data.Repository;

namespace RestAPIModelo.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();
            //
            //builder.Register(ctx => new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile(new DtoToModelMappingClient());
            //    cfg.AddProfile(new ModelToDtoMappingClient());
            //    cfg.AddProfile(new DtoToModelMappingProduct());
            //    cfg.AddProfile(new ModelToDtoMappingProduct());
            //}));

            //builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }
}