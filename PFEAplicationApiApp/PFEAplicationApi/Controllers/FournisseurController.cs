using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFEServices.Fourniseur.services;
using PFEServices.Models;

namespace PFEAplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FournisseurController : ControllerBase
    {
        private readonly IFournisseur _fournisseurService;

        public FournisseurController(IFournisseur fourni)
        {
            _fournisseurService = fourni;
        }
        [HttpGet]
        [Route("Getfournisseur")]
        public async Task<ActionResult<List<FournisseurDto>>> GetAllFournisseur()
        {
            return Ok(_fournisseurService.GetFourni());
        }
        [HttpPost]
        [Route("AddFournisseur")]
        public async Task<ActionResult<FournisseurDto>> AddFournisseur([FromBody] FournisseurDto fournisseur)
        {
            var result = await _fournisseurService.AddFourni(fournisseur);
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpPut]
        [Route("UpdateFournisseur")]
        public async Task<ActionResult<FournisseurDto>> UpdateUser(int id, [FromBody] FournisseurDto fournisseur)
        {
            var result = await _fournisseurService.UpdateFourni(id,fournisseur);
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpDelete]
        [Route("Delet")]
        public async Task<ActionResult<FournisseurDto>> DeletFournisseur(int id)
        {
            var result = await _fournisseurService.DeleteFourni(id);
            if (result == null)
                return NotFound();
            else
                return Ok(result);

        }







    }
}
