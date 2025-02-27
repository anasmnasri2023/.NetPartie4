using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Veuillez entrer une date valide.")]
        public  DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "Le numéro de passeport doit contenir exactement 7 caractères.")]
        public string PassportNumber{ get; set; }

        
        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse email valide.")]
        public string Emailadress{ get; set; }

        
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Le prénom doit contenir entre 3 et 25 caractères.")]
        public string FirstName{ get; set; }
        public string LastName { get; set; }

        
        [Phone(ErrorMessage = "Veuillez entrer un numéro de téléphone valide.")]
        public int Telnumber { get; set; }
        public IList<Flight> Flightes { get; set; }
        
        public int Age => DateTime.Now.Year - BirthDate.Year;

        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return CheckProfile(firstName, lastName) && Emailadress == email;
        }

        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }

        public void GetAge(DateTime birthDate, ref int calculatedAge)
        {
            calculatedAge = DateTime.Now.Year - birthDate.Year;
        }

        public void GetAge(Passenger passenger)
        {
            passenger.BirthDate = BirthDate;
        }



    }
}
