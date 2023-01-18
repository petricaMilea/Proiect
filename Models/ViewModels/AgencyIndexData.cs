using System.Security.Policy;

namespace Proiect.Models.ViewModels
{
    public class AgencyIndexData
    {
        public IEnumerable<Agency> Agencies { get; set; }
        public IEnumerable<Holiday> Holidays { get; set; }
    }
}
