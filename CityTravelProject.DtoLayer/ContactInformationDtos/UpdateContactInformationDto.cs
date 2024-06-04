using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DtoLayer.ContactInformationDtos
{
    public class UpdateContactInformationDto
    {
        public int ContactInformationID { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string MapURL { get; set; }
        public bool Status { get; set; }
    }
}
