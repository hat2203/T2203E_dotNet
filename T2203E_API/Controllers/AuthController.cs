using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using T2203E_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using T2203E_API.Dtos;

namespace T2203E_API.Controllers
{
    [ApiController]
    [Route("api/register")]
    public class AuthController : ControllerBase
    {
        private readonly T2203eApiContext _context;
        public AuthController(T2203eApiContext context)
        {
           _context = context;
        }

        [HttpGet]
        [Route("/register")]
        public IActionResult Register(UserRegister auth)
        {
            var hashed = BCrypt.Net.BCrypt.HashPassword(auth.Password);
            _ = _context.Users.Add(new Entities.User { Email = auth.Email, Name = auth.Name, Password = hashed });
            _context.SaveChanges();
            return Ok(new UserData { Name = auth.Name, Email = auth.Email });
        }
        //[HttpPost]
        //[Route("/login")]
        //public IActionResult Login(UserLogin auth)
        //{

        //}
    }
}
