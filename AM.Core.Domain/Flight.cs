using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{    
    public class Flight
    {
        public string Comment { get; set; }
        public  string Destination { get; set; }
        public string Departure { get; set; }
        public  DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public string EffectiveArrival { get; set; }
        public  double EstimetedDuration { get; set; }

        // OUbien [ForeignKey("PlaneId")]
        public Plane MyPlane { get; set; }

        [ForeignKey("MyPlane")]
        public int? PlaneId { get; set; }
        public IList<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return "Flighid :" + FlightId + "Distination :" + Destination +
                "Departure :" + Departure + "FlightDate :" + FlightDate +
                "EffectiveArrival :"
                + EffectiveArrival + "EstimetedDuration : " + EstimetedDuration;
        }


    }
}
