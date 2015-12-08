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
            double result = 0;
            switch (this.Movie.PriceCode)
            {
                case Movie.REGULAR:
                    result += 2;
                    if (this.DayRented > 2)
                    {
                        result += (this.DayRented - 2) * 1.5;
                    }
                    break;
                case Movie.NEW_RELEASE:
                    result += this.DayRented * 3;
                    break;
                case Movie.CHILDRENS:
                    result += 1.5;
                    if (this.DayRented > 3)
                    {
                        result += (this.DayRented - 3) * 1.5;
                    }
                    break;
            }
            return result;
        }

        public int GetFrequentRenterPoints()
        {
            if ((this.Movie.PriceCode == Movie.NEW_RELEASE) && this.DayRented > 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        
    }
}
