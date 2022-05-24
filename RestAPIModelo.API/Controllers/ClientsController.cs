using Microsoft.AspNetCore.Mvc;
using RestAPIModelo.Application;
using RestAPIModelo.Application.Dtos;
using RestAPIModelo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIModelo.API.Controllers
{

    [Route("client/")]
    [ApiController]

    public class ClientsController : ControllerBase
    {

        private readonly IApplicationServiceClient applicationServiceClient;


        public ClientsController(ApplicationServiceClient applicationServiceClient)
        {
            this.applicationServiceClient = applicationServiceClient;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceClient.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceClient.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Add(clientDTO);
                return Ok("Successfully registered customer!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Update(clientDTO);
                return Ok("Customer Updated Successfully!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Remove(clientDTO);
                return Ok("Client successfully removed!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}