namespace CityTravelProject.PresentationLayer.Dtos.ContactInformationDto
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
