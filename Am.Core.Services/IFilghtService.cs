using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace Am.Core.Services
{
    internal interface IFilghtService
    {
        IList<DateTime> GetFlightDates(string Destination);
        IList<DateTime> GetFlightDatesLinq(string Destination);
        IList<Flight> GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int GetWeeklyFlightNumber(DateTime date);
        double GetDurationAverage(string destination);
        IList<Flight> SortFlights();
        IList<Passenger> GetThreeOlderTravellers(Flight flight);
        void ShowGroupedFlights();
    }
}
