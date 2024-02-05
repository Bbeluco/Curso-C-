using System;
using CustomExceptions;

namespace Exceptions {
    internal class CustomExceptions {
        static void Main(string[] args) {
            try {
                System.Console.Write("Room number: ");
                int room = int.Parse(Console.ReadLine());
                System.Console.Write("Check-in date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(room, checkIn, checkOut);
                System.Console.WriteLine(reservation);

                System.Console.WriteLine();

                System.Console.WriteLine("Enter data to update the reservation: ");
                System.Console.Write("Check-in date: ");
                DateTime newCheckIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date: ");
                DateTime newCheckOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(newCheckIn, newCheckOut);
                System.Console.WriteLine(reservation);
            }
            catch(DomainException e) {
                System.Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}