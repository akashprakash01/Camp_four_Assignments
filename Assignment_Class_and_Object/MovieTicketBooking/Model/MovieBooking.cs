using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking.Model
{
    public class MovieBooking
    {
        //instance variable data hiding
        private string movieName;
        private int totalSeats;
        private int bookedSeats;
        private int remainingSeats;

        //constructor
        public MovieBooking()
        {
            totalSeats = 120;
            remainingSeats = 120;
        }

        //parameterized constructor
        public MovieBooking(string _movieName, int _bookedSeats)
        {
            this.movieName = _movieName;
            this.totalSeats = 120;
            this.bookedSeats = _bookedSeats;
            this.remainingSeats = 120;
            
        }

        //encapsulation
        // Property to get or set the movie name.
        public string MovieName
        {
            get { return this.movieName; }
            set
            {
                //validating the movie name
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Movie name should not be empty");
                else
                    movieName = value;
            }
        }

        // Property to get or set the Booked Seats.
        public int BookedSeats
        {
            get { return this.bookedSeats; }
            set
            {
                //booking seat validation
                if (value > 10)
                {
                    Console.WriteLine("Cannot book more than 10 seats at a time");
                }
                else if (value > totalSeats)
                {
                    Console.WriteLine("---------Housefull---------");
                }
                else
                {
                    bookedSeats = value;
                    remainingSeats -= value;
                    Console.WriteLine("Seat booked");
                }
            }
        }


        // booked seat cancellation method
        public bool CancelSeats(int alreadyBooked)
        {
            if (alreadyBooked > 0 && alreadyBooked <= bookedSeats)
            {
                bookedSeats -= alreadyBooked;
                remainingSeats += alreadyBooked;
                Console.WriteLine($"Canceled seats total: {alreadyBooked} ");
                return true;
            }
            else
            {
                Console.WriteLine("Cannot Cancel more seats than booked");
                return false;
            }
        }

        //Overriding ToString() to display Product details
        public override string? ToString()
        {
            return $"Movie name {MovieName} TotalSeats {totalSeats} Booked {BookedSeats} remaining Seats: {remainingSeats}";
        }
    }
}
