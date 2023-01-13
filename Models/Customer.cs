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

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\+[0-9]{2}[0-9]{3}[0-9]{6}$", ErrorMessage ="Introduce numarul de telefon de tipul '+40712345678'"), Required]
        public string PhoneNumber { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public ICollection<Offer>? Offers { get; set; }
    }
}
