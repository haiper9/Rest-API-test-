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
    [Route("controller1")]
    public class CoordController : ControllerBase
    {
        CoordsContext db;
        public CoordController(CoordsContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coords>>> Get()
        {  
            return await db.coords.ToListAsync();
        }
        

        [HttpGet("{id}")]
        public async Task<ActionResult<Coords>> Get(int id)
{
            Coords coords = await db.coords.FirstOrDefaultAsync(x => x.Id == id);
            if (coords == null)
                return NotFound();
            return new ObjectResult(coords);
        }
    }
}
