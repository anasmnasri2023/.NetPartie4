using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum Planetype
    {
        Boing,
        Airbus
    }
    public class Plane
    {
        [Range(0, int.MaxValue, ErrorMessage = "La capacité doit être un entier positif.")]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public Planetype MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return base.ToString() + "PlaneId :" + PlaneId +
                "Capacity :" + Capacity
                + "ManufactureDate :" + ManufactureDate + "planetype :" + MyPlaneType;

        }
        public Plane(int capacity, DateTime manufacturedate, Planetype plantype)
        {
            Capacity = capacity;
            ManufactureDate = manufacturedate;
            MyPlaneType = plantype;


        }
        public Plane() { }
    }
}
