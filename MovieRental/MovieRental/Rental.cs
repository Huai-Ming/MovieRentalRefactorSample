using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class Rental
    {
        public Movie Movie{get; private set;}

        public int DayRented { get; private set; }

        public Rental(Movie movie, int daysRented)
        {
            this.Movie = movie;
            this.DayRented = daysRented;
        }

        
    }
}
