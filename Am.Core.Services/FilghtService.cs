using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace Am.Core.Services
{
    internal class FilghtService
    {
        public IList<Flight> Flights { get; set; }

        public List<DateTime> GetFlightDates(string Destination)
        {
            List<DateTime> flightDates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination == Destination)
                {
                    flightDates.Add(flight.FlightDate);
                }
            }
            return flightDates;
        }


        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            List<Flight> filteredFlights = new List<Flight>();

            foreach (var flight in Flights)
            {
                var property = typeof(Flight).GetProperty(filterType);

                if (property != null) 
                {
                    var propertyValue = property.GetValue(flight)?.ToString();

                    if (propertyValue == filterValue) 
                    {
                        filteredFlights.Add(flight);
                    }
                }
            }

            return filteredFlights;
        }

        public List<DateTime> GetFlightDatesLinq(string Destination)
        {
            return Flights.Where(f => f.Destination == Destination)
                          .Select(f => f.FlightDate)
                          .ToList();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var objects = Flights
                .Where(f => f.MyPlane.PlaneId == plane.PlaneId)
                //.Select(f => (f.flightDate,f.destination))
                .Select(f => new { f.FlightDate, f.Destination })
                ;

            foreach (var obj in objects)
            {
                Console.WriteLine($"Date: {obj.FlightDate}, Destination: {obj.Destination}");
            }
        }

        public int GetWeeklyFlightNumber(DateTime date)
        {
            var endDate = date.AddDays(7);
            return Flights.Count(f => f.FlightDate >= date && f.FlightDate < endDate);
        }

        public double GetDurationAverage(string destination)
        {
            return Flights
                .Where(f => f.Destination == destination)
                .Average(f => f.EstimetedDuration);
        }

        public IList<Flight> SortFlights()
        {
            return Flights
                .OrderByDescending(f => f.EstimetedDuration)
                .ToList();
        }

        public IList<Passenger> GetThreeOlderTravellers(Flight flight)
        {
            return flight.Passengers
                .OrderBy(f => f.BirthDate)
                .Take(3)
                .ToList();
        }

        public void ShowGroupedFlights()
        {
            var groupedFlights = Flights
                .GroupBy(f => f.Destination);

            foreach (var group in groupedFlights)
            {
                Console.WriteLine($"Destination: {group.Key}");
                foreach (var flight in group)
                {
                    Console.WriteLine($"  Flight ID: {flight.FlightId}, Date: {flight.FlightDate}");
                }
            }
        }
    }
}
