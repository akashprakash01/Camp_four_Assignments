using MovieTicketBooking.Model;

namespace MovieTicketBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //program header
            Console.WriteLine("-------------Movie Ticket Booking-----------");

            // object creation for the class  MovieBooking
            MovieBooking movieOne = new MovieBooking();
            // assigning movie and  seats booked 
            movieOne.MovieName = "F1";
            movieOne.BookedSeats = 7;

            // Display current booking details
            Console.WriteLine(movieOne.ToString());

            // Cancel previously booked seats
            movieOne.CancelSeats(2);
            // Display current booking details
            Console.WriteLine(movieOne.ToString());

            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
