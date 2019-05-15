using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoozyHops.Models
{
    public class BoozyHopsDb :DbContext
    {
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<BreweryReview> Reviews{ get; set; }
    }
}
