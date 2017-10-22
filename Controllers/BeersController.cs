using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beerAPI.Models;
using beerAPI.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace beerAPI.Controllers
{
    [Route("api/[controller]")]
    public class BeersController : Controller
    {
        private readonly BeerAPIDbContext context;
        public BeersController(BeerAPIDbContext context)
        {
            this.context = context;
        }


        // GET api/beers
        [HttpGet]
       public async Task<IEnumerable<Models.Beer>> Get()
        {
            return await context.Beers.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBeer([FromBody] Beer beer)
        {
            if (beer == null)
            {
                return BadRequest();
            }
            context.Beers.Add(beer);
            await context.SaveChangesAsync();
            return Ok(beer);
        }
    }
}
