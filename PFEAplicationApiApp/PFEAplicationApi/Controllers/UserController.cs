using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFEServices.Models;
using PFEServices.UtilisateurS;

namespace PFEAplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUtilisateur _utilisateurService;

        public UserController(IUtilisateur utilisateur)
        {
            _utilisateurService = utilisateur;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> login([FromBody]UtilisateurDto utilisateurDto)
        {
            var loginResult = await _utilisateurService.login(utilisateurDto);
            return Ok(loginResult);
        }
    }
}
