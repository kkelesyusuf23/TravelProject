﻿namespace CityTravelProject.PresentationLayer.Dtos.CityMapsDtos
{
    public class UpdateCityMapsDto
    {
        public int CityMapsID { get; set; }
        public string City { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
    }
}
