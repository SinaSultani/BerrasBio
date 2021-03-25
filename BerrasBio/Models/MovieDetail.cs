using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasBio.Models
{
    public class MovieDetail
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string WhenMovieStarts { get; set; }
        public int AvailableSeats { get; set; }

    }
}
