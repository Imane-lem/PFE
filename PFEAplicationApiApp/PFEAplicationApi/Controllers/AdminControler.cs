using Microsoft.AspNetCore.Mvc;
using PFEServices.Administration.service;
using PFEServices.Models;

namespace PFEAplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminControler:ControllerBase
    {
        private readonly IAdministration _AdminService;

        public AdminControler(IAdministration Admin)
        {
            _AdminService = Admin;
        }
        [HttpGet]
        [Route("GetUsers")]
        public async Task<ActionResult<List<UserDto>>> GetAllUsers()
        {
            return Ok(_AdminService.GetUsers());
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult<UserDto>> AddUser( [FromBody]UserDto user)
        {
            var result = await _AdminService.AddUser(user);
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpPut]
        [Route("UpdateUser")]
        public async Task<ActionResult<UserDto>> UpdateUser( int id,[FromBody]UserDto user)
        {
            var result= await _AdminService.UpdateUser(id,user);
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpDelete]
        [Route("Delet")]
        public async Task<ActionResult<UserDto>> DeletUser( int id)
        {
            var result = _AdminService.DeleteUser(id);
            if (result == null)
                return NotFound();
            else
                return Ok(result);

        }
        [HttpGet]
        [Route("getbyid")]
        public async Task<ActionResult<List<UserDto>>> GetuseById(int id)
        {
            var pro = await _AdminService.GetUserById(id);
            if (pro == null)
                return null;
            return Ok(pro);
        }
        [HttpGet]
        [Route("search")]
        public async Task<ActionResult<List<UserDto>>> SearchUser(string name)
        {
            var result=await _AdminService.Search(name);
            if (result == null)
                return null;
            return Ok(result);
        }



    }
}
