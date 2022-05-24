using RestAPIModelo.Application.Dtos;
using RestAPIModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestAPIModelo.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoEntity(ClientDto clientDto);

        IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients);

        ClientDto MapperEntityToDto(Client client);
    }
}