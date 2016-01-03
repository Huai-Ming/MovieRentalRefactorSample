using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        public string Title { get; set; }

        public int PriceCode 
        {
            get { return price.GetPriceCode(); }
        }

        private Price price;

        public Movie(string title, int priceCode)
        {
            this.Title = title;
            SetPriceCode(priceCode);
        }

        public void SetPriceCode(int priceCode)
        {
            switch(priceCode)
            {
                case REGULAR:
                    price = new RegularPrice();
                    break;

                case CHILDRENS:
                    price = new ChidrensPrice();
                    break;

                case NEW_RELEASE:
                    price = new NewReleasesPrice();
                    break;

                default:
                    throw new ArgumentException("Incorrect Price code");
            }
        }

        /// <summary>
        /// Extract Method
        /// </summary>
        /// <param name="rental"></param>
        /// <returns></returns>
        public double GetCharge(int daysRented)
        {
            return this.price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return this.price.GetFrequentRenterPoints(daysRented);
        }
    }
}
