using RestAPIModelo.Application.Dtos;
using RestAPIModelo.Application.Interfaces.Mappers;
using RestAPIModelo.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIModelo.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        public Client MapperDtoEntity(ClientDto clientDto)
        {
            var client = new Client()
            {
                Id = clientDto.Id
            ,
                Name = clientDto.Name
            ,
                SurName = clientDto.SurName
            ,
                Email = clientDto.Email
            };
            return client;
        }

        public ClientDto MapperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id
            ,
                Name = client.Name
            ,
                SurName = client.SurName
            ,
                Email = client.Email
            };
            return clientDto;
        }

        public IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDto
            {
                Id = c.Id
                                                         ,
                Name = c.Name
                                                         ,
                SurName = c.SurName
                                                         ,
                Email = c.Email
            });

            return dto;
        }
    }
}