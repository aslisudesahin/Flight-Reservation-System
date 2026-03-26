using System;

namespace FligthReservationSystem
{
    public class Reservation
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int CustomerId { get; set; }
        public string SeatNumber { get; set; }
        public decimal TotalPrice { get; private set; }

        
        public Reservation(int flightId, Flight flight, int customerId, string seatNumber)
        {
            FlightId = flightId;
            Flight = flight;
            CustomerId = customerId;
            SeatNumber = seatNumber;
        }

        public void CalculateFinalPrice(string couponCode = "")
        {
            if (Flight == null) return;
            decimal price = Flight.BasePrice;

            //  Kalan Gün Etkisi
            double daysLeft = (Flight.DepartureDate - DateTime.Now).TotalDays;
            if (daysLeft > 15) price *= 0.85m; // %15 indirim
            else if (daysLeft < 3 && daysLeft >= 0) price *= 1.25m; // %25 zam

            //  Koltuk Tipi Etkisi (İlk 30 Business)
            if (int.TryParse(SeatNumber, out int sn) && sn <= 30) price += 500;

            //  Sezon Etkisi
            if (Flight.IsHighSeason) price *= 1.20m; // %20 sezon zammı

            //  Doluluk Oranı Etkisi
            // Eğer uçaktaki boş yer  30'un altına düşerse %15 zam yapılır
            if (Flight.Capacite < 30) price *= 1.15m;

            // 5. Kupon Etkisi
            if (couponCode == "FINAL100") price *= 0.90m; // %10 indirim

            TotalPrice = Math.Round(price, 2);
        }
    }
}