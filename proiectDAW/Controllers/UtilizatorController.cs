using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiectDAW.Models.DTO;
using proiectDAW.Models.Many_to_Many;
using proiectDAW.Servicii;
using proiectDAW.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilizatorController : ControllerBase
    {
        private IUserService _userService;

        public UtilizatorController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("autentificare")]
        public IActionResult Autentificare(UserRequestDTO user)
        {
            var response = _userService.Autentificare(user);
            if (response == null)
            {
                return BadRequest(new { Message = "Email-ul sau parola sunt invalide" });
            }

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("create")]
        public IActionResult Create(UserRequestDTO user)
        {
            var userToCreate = new Utilizator
            {
                Nume = user.Nume,
                Prenume = user.Prenume,
                Email = user.Email,
                Parola = BCrypt.Net.Bcrypt.HashPassword(user.Parola),
                Rol = Rol.User
            };

            return Ok();
        }

       // [Authorize(Roles = "Admin")]

       //verificare custom definita in Utilities/Authorization.cs
       [Authorization(Rol.Admin)]
       [HttpGet]
        public IActionResult GetAllusers()
        {
            var users = _userService.GetAllUsers();
            return Ok(User);
        }
    }
}
