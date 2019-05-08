using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoozyHops.Models
{
    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public ICollection<BreweryReview> Reviews { get; set; }
    }
}
