using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proiect.Models
{
    public class Agency
    {
        public int ID { get; set; }

        [Required, StringLength(150, MinimumLength = 3)]
        [Display(Name ="Travel Agency")]
        public string Name { get; set; }

        public string Address { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"), Required]
        public string Contact { get; set; }

        public ICollection<Holiday>? Holidays { get; set; }
    }
}
