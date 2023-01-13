using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Offer
    {
        public int ID { get; set; }

        public int? CustomerID { get; set; }
        public Customer? Customer { get; set; }

        public int? HolidayID { get; set; }
        public Holiday? Holiday { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Offer date")]
        public DateTime OfferDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Valid until")]
        public DateTime ValidDate { get; set; }

    }
}
