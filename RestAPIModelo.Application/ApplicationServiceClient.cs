using RestAPIModelo.Application.Interfaces;
using RestAPIModelo.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using RestAPIModelo.Domain.Entitys;
using RestAPIModelo.Application.Dtos;

namespace RestAPIModelo.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapper mapper;
        public ApplicationServiceClient(IServiceClient serviceClient
                                       , IMapper mapper)
        {
            this.serviceClient = serviceClient;
            this.mapper = mapper;
        }
        public void Add(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Add(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            var clientsDto = mapper.Map<IEnumerable<ClientDto>>(clients);

            return clientsDto;
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            var clientDto = mapper.Map<ClientDto>(client);

            return clientDto;
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Update(client);
        }
    }

}