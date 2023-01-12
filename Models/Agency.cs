using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proiect.Models
{
    public class Agency
    {
        public int ID { get; set; }
        [Display(Name ="Travel Agency")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
}
