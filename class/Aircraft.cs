using FligthReservationSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightResSystem.Models
{
    public class Aircraft
    {
        public int AircraftId { get; private set; }
        public string Model { get; private set; }
        public int TotalCapacity { get; private set; }
        public string Configuration { get; private set; }

        // OOP İlişkisi: Bu uçağa atanmış olan uçuşların listesi
        public ICollection<Flight> Flights { get; } = new ObservableCollection<Flight>();

        
        public Aircraft()
        {
        }

        public Aircraft(int aircraftId, string model, int capacity, string configuration)
        {
            AircraftId = aircraftId;
            Model = model;
            TotalCapacity = capacity;
            Configuration = configuration;
        }


        public string GetSeatConfiguration()
        {
            // Bu metot, Configuration stringini işleyerek daha detaylı bilgi sunar
            return $"Model: {Model}, Toplam Kapasite: {TotalCapacity}, Düzen: {Configuration}";
        }

        // Admin'in bu uçağı belirli bir uçuşa ataması için yardımcı metot
        public void AssignToFlight(Flight flight)
        {
         
            if (flight != null && !Flights.Contains(flight))
            {
                Flights.Add(flight);
            }
        }
    }
}
