﻿namespace CityTravelProject.PresentationLayer.Dtos.LocationDtos
{
    public class CreateLocationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string PhotoURL { get; set; }
        public bool Status { get; set; }
    }
}
