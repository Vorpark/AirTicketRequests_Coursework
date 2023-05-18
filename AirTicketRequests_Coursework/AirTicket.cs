using System;

namespace AirTicketRequests_Coursework
{
    public class AirTicket
    {
        public int FlightNumber { get; set; } //Номер рейса
        public string PassengerName { get; set; } // ФИО пассажира
        public string Date { get; set; } // Дата вылета
        public string Destination { get; set; } // Место прибытия
        public AirTicket(int flightNumber, string passengerName, string date, string destination) 
        { 
            FlightNumber = flightNumber;
            PassengerName = passengerName;
            Date = date;
            Destination = destination;
        }
    }
}
