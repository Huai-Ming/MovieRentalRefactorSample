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
            string result = "Rental record for " + this.Name + "\n";

            foreach(var rental in rentals)
            {
                result += "\t" + rental.Movie.Title + "\t" + rental.GetCharge() + "\n";
            }

            // add footer lines
            result += "Amount owed is " + GetTotalCharge() + "\n";
            result += "You earned " + GetTotalRenterPoints() + " frequent renter points";
            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;
            foreach (var rental in rentals)
            {
                result += rental.GetCharge();
            }
            return result;
        }

        private double GetTotalRenterPoints()
        {
            int frequentRenterPoints = 0;
            foreach (var rental in rentals)
            {
                frequentRenterPoints += rental.GetFrequentRenterPoints();
            }
            return frequentRenterPoints;
        }

    }
}
