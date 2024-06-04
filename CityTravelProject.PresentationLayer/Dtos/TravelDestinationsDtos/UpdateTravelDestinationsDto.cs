namespace CityTravelProject.PresentationLayer.Dtos.TravelDestinationsDtos
{
    public class UpdateTravelDestinationsDto
    {
        public int TravelDestinationsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
    }
}
