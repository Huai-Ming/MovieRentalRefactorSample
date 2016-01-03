using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public abstract class Price
    {
        public abstract int GetPriceCode();

        /// <summary>
        /// Extract Method
        /// </summary>
        /// <param name="rental"></param>
        /// <returns></returns>
        public abstract double GetCharge(int daysRented);


        public virtual int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }

    public class ChidrensPrice: Price
    {
        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 1.5;
            if (daysRented > 3)
            {
                result += (daysRented - 3) * 1.5;
            }
            return result;
        }
       
    }

    public class NewReleasesPrice: Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            if (daysRented > 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }

    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
            {
                result += (daysRented - 2) * 1.5;
            }

            return result;
        }
    }
}
