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
    }
}
