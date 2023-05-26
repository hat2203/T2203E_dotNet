using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using T2203E_API.Entities;

namespace T2203E_API.Controllers{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BrandsController : ControllerBase
    {
        private readonly T2203eApiContext _context;
        public BrandsController(T2203eApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var brand = _context.Brands.ToList<Brand>();
            return Ok(brand);
        }

        [HttpGet]
        [Route("get-by-id")]
        public IActionResult Get(int id)
        {
            var brand = _context.Brands.Find(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }

        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
            return Created($"/get-by-id?id={brand.Id}", brand);
        }

        [HttpPut]
        public IActionResult Update(Brand brand)
        {
            _context.Brands.Update(brand);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var brand = _context.Brands.Find(id);
            if (brand == null)
                return NotFound();
            _context.Brands.Remove(brand);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
