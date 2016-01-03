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

        /// <summary>
        /// Extract Method
        /// </summary>
        /// <param name="rental"></param>
        /// <returns></returns>
        public double GetCharge()
        {
            return this.Movie.GetCharge(this.DayRented);
        }

        public int GetFrequentRenterPoints()
        {
            return this.Movie.GetFrequentRenterPoints(this.DayRented);
        }

        
    }
}
