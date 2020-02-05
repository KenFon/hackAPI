using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackAPI.Data;
using hackAPI.Dtos;
using hackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hackAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        
        private readonly IUserRepository _repo;

        public RegisterController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {

            var userToCreate = new User 
            {
                Name = userForRegisterDto.Name,
                LastName = userForRegisterDto.LastName,
                Contact = userForRegisterDto.Contact,
                Company = int.Parse(userForRegisterDto.Company),
                Age = int.Parse(userForRegisterDto.Age),
                CompanyName = userForRegisterDto.CompanyName 
            }; 

            var createdUser = await _repo.Register(userToCreate);

            return StatusCode(201);
        }
    }
}

