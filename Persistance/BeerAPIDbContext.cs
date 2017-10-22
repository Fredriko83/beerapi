using Microsoft.EntityFrameworkCore;
using beerAPI.Models;

namespace beerAPI.Persistance
{
    public class BeerAPIDbContext:DbContext
    {
        public BeerAPIDbContext(DbContextOptions<BeerAPIDbContext> options)
        : base(options)
        {
        }
        public DbSet<Beer> Beers{get; set;}
    }
}