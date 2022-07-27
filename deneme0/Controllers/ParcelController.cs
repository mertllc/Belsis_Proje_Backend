using deneme0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proje_deneme.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace deneme0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcelController : ControllerBase
    {
        private readonly ParcelDbContext _context;
        public ParcelController(ParcelDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Parcel> Get()
        {
            return _context.Parcels.ToList();
        }

        [HttpPost]
        public IActionResult AddEntity(Parcel par)
        {
            _context.Parcels.Add(par);
            _context.SaveChanges();

            return Ok(par.Id);
        }
        [HttpDelete]
        public IActionResult DeleteEntity(Parcel par)
        {

            var value = _context.Parcels.Where(p => p.wkt == par.wkt).FirstOrDefault();
            if (value == null)
            {
                return NotFound();
            }
            _context.Parcels.Remove(value);
            _context.SaveChanges();
            return Ok(par.Id);
        }

        [HttpPut]

        public IActionResult UpdateEntity(Parcel context)
        {
            _context.Parcels.Update(context);
            _context.SaveChanges();
            return NoContent();
        }

    }
 
}
