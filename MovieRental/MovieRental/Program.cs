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
            Rental rental3 = new Rental(movie3, 3);

            Customer customer = new Customer("Tom");
            customer.AddRental(rental1);
            customer.AddRental(rental2);
            customer.AddRental(rental3);

            Console.Write(customer.Statement());
            Console.Read();
        }
    }
}
