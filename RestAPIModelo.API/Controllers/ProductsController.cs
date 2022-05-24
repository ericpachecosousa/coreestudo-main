using Microsoft.AspNetCore.Mvc;
using RestAPIModelo.Application.Dtos;
using RestAPIModelo.Application.Interfaces;
using RestAPIModelo.Application.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIModelo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IApplicationServiceProduct applicationServiceProduct;

        public ProductsController(ApplicationServiceProduct applicationServiceProduct)
        {
            this.applicationServiceProduct = applicationServiceProduct;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceProduct.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceProduct.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();


                applicationServiceProduct.Add(productDTO);
                return Ok("The product was successfully registered");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProductDto productDTO)
        {

            try
            {
                if (productDTO == null)
                    return NotFound();

                applicationServiceProduct.Update(productDTO);
                return Ok("The product has been successfully updated!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDto productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();

                applicationServiceProduct.Remove(productDTO);
                return Ok("The product has been removed successfully!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}