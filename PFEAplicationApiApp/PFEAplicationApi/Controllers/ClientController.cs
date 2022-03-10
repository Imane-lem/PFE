using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFEServices.Client.services;
using PFEServices.Models;

namespace PFEAplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClient _clientService;

        public ClientController(IClient client)
        {
            _clientService = client;
        }
        [HttpGet]
        [Route("GetClient")]
        public async Task<ActionResult<List<ClientDto>>> GetClient()
        {
            return Ok(_clientService.GetClients());
        }
        [HttpPost]
        [Route("AddClient")]
        public async Task<ActionResult<ClientDto>> AddClient([FromBody] ClientDto clientDto)
        {
            var result = await _clientService.AddClient(clientDto);
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpPut]
        [Route("UpdateClient")]
        public async Task<ActionResult<ClientDto>> UpdateClient(int id,[FromBody] ClientDto clientDto)
        {
            var result = await _clientService.UpdateClient(id, clientDto);
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpDelete]
        [Route("Delet")]
        public async Task<ActionResult<ClientDto>> DeleteClient(int id)
        {
            var result = await _clientService.DeleteClient(id);
            if (result == null)
                return NotFound();
            else
                return Ok(result);

        }








    }
}
       
 

