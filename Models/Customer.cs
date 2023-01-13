using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\\+?[1-9][0-9]{7,14}$", ErrorMessage ="Introduce numarul de telefon de tipul '*40712345678'"), Required]
        public string PhoneNumber { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
