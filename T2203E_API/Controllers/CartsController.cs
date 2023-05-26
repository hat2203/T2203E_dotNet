using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using T2203E_API.Entities;

namespace T2203E_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CartsController : ControllerBase
    {
        private readonly T2203eApiContext _context;
        public CartsController(T2203eApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cart = _context.Carts.ToList<Cart>();
            return Ok(cart);
        }

        [HttpPost]
        public IActionResult Create(Cart cart)
        {

           return Ok(cart);
        }
    }
}
