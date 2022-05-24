using AutoMapper;
using RestAPIModelo.Application.Dtos;
using RestAPIModelo.Application.Interfaces;
using RestAPIModelo.Domain.Core.Interfaces.Services;
using RestAPIModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestAPIModelo.Application.Mappers
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapper mapper;

        public ApplicationServiceProduct(IServiceProduct serviceProduct
                                  , IMapper mapper)
        {
            this.serviceProduct = serviceProduct;
            this.mapper = mapper;
        }

        public void Add(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = serviceProduct.GetAll();
            var productsDto = mapper.Map<IEnumerable<ProductDto>>(products);
            return productsDto;
        }

        public ProductDto GetById(int id)
        {
            var product = serviceProduct.GetById(id);
            var productDto = mapper.Map<ProductDto>(product);
            return productDto;
        }

        public void Remove(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            serviceProduct.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            serviceProduct.Update(product);
        }
    }
}