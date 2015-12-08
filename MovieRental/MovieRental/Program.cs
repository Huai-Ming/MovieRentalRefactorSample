using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Movie movie1 = new Movie("007", Movie.NEW_RELEASE);
            Movie Movie2 = new Movie("Cat and Mouse", Movie.CHILDRENS);
            Movie movie3 = new Movie("The Lost", Movie.REGULAR);
            Rental rental1 = new Rental(movie1, 10);
            Rental rental2 = new Rental(Movie2, 2);
            Rental rental3 = new Rental(movie3, 4);

            Customer customer = new Customer("Tom");
            customer.AddRental(rental1);
            customer.AddRental(rental2);
            customer.AddRental(rental3);

            Console.Write(customer.Statement());

            //Original value
//            Rental record for Tom
//        007     30
//        Cat and Mouse   1.5
//        The Lost        5
//Amount owed is 36.5
//You earned 4 frequent renter points
            Console.Read();
        }
    }
}
