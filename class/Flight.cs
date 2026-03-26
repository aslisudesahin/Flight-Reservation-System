using System;

namespace FligthReservationSystem
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public int Capacite { get; set; } 
        public int AircraftId { get; set; }
        public decimal BasePrice { get; set; }
        public bool IsHighSeason { get; set; }

   
        public Flight(int flightId, string flightNumber, string departureCity, string arrivalCity,
                      DateTime departureDate, TimeSpan departureTime, int capacite,
                      int aircraftId, decimal basePrice, bool isHighSeason)
        {
            FlightId = flightId;
            FlightNumber = flightNumber;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            DepartureDate = departureDate;
            DepartureTime = departureTime;
            Capacite = capacite;
            AircraftId = aircraftId;
            BasePrice = basePrice;
            IsHighSeason = isHighSeason;
        }

        public Flight() { }
    }
}