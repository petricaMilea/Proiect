using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proiect.Models
{
    public class Holiday
    {
        public int ID { get; set; }

        [Display(Name = "Package Holidays")]
        public string HolidayName { get; set; }

        public string Country { get; set; }

        public string Details { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "decimal(7, 2)")]
        public decimal Price { get; set; }

        public int AgencyID { get; set; }

        public Agency Agency { get; set; }
    }
}
