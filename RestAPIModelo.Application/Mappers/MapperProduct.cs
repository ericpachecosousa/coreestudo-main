using RestAPIModelo.Application.Dtos;
using RestAPIModelo.Application.Interfaces.Mappers;
using RestAPIModelo.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIModelo.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id
                ,
                Name = productDto.Name
                ,
                Value = productDto.Value
            };
            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id
                      ,
                Name = product.Name
                      ,
                Value = product.Value
            };
            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> product)
        {
            var dto = product.Select(c => new ProductDto
            {
                Id = c.Id
                                                        ,
                Name = c.Name
                                                        ,
                Value = c.Value
            });

            return dto;
        }
    }
}