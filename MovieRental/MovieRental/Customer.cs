using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class Customer
    {
        public string Name { get; set; }

        private List<Rental> rentals = new List<Rental>();

        public Customer(string name)
        {
            this.Name = name;
        }

        public void AddRental(Rental arg)
        {
            rentals.Add(arg);
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = "Rental record for " + this.Name + "\n";

            foreach(var rental in rentals)
            {
                double thisAmount = 0;

                switch(rental.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if(rental.DayRented > 2)
                        {
                            thisAmount += (rental.DayRented - 2) * 1.5;
                        }
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += rental.DayRented * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if(rental.DayRented >3)
                        {
                            thisAmount += (rental.DayRented - 3) * 1.5;
                        }
                        break;
                }

                //add frequent renter points
                frequentRenterPoints++;
                if((rental.Movie.PriceCode == Movie.NEW_RELEASE) && rental.DayRented > 1)
                {
                    frequentRenterPoints++;
                }

                result += "\t" + rental.Movie.Title + "\t" + thisAmount + "\n";
            }

            // add footer lines
            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points";
            return result;
        }
    }
}
