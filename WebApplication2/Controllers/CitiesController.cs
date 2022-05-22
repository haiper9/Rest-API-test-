using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("controller")]
    public class Controller : ControllerBase
    {
        CitiesContext db;
        public Controller(CitiesContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> Get()
        {
            return await db.Cities.Include(x=>x.Coords).ToListAsync();
        }
        
        

        [HttpGet("{id}")]
        public async Task<ActionResult<City>> Get(int id)
{
            City city = await db.Cities.Include(x=>x.Coords).FirstOrDefaultAsync(x => x.Id == id);
            if (city == null)
                return NotFound();
            return new ObjectResult(city);
        }
    }

}
