using RestAPIModelo.Application.Dtos;
using RestAPIModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestAPIModelo.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoEntity(ProductDto productDto);

        ProductDto MapperEntityToDto(Product product);

        IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> product);
    }
}