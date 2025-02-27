using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Traveller : Passenger
    {
        public string Healthinformation { get; set; }
        public string Natioality { get; set; }

        public override string ToString() { 
            return base.ToString()+
                "Healthinformation" + Healthinformation 
                + "Natioality" + Natioality;
        
        }

        public override string GetPassengerType()
        {
            return "I am a Traveller";
        }

    }
}
