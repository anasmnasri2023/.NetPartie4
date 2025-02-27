using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Fonction { get; set; }

        
        [DataType(DataType.Currency, ErrorMessage = "Veuillez entrer une valeur monétaire valide.")]
        public int Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + "EmployementDate :"
                + EmployementDate + "fonction :"
                + Fonction + "salary :" + Salary;

        }

        public override string GetPassengerType()
        {
            return base.GetPassengerType() + " I am a Staff Member";
        }

    }
}
