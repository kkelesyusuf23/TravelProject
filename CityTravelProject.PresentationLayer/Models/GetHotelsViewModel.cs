namespace CityTravelProject.PresentationLayer.Models
{
    public class GetHotelsViewModel
    {

        public class Rootobject
        {
            public Datum[] data { get; set; }
            public Meta meta { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        public class Meta
        {
            public int currentPage { get; set; }
            public int limit { get; set; }
            public int totalRecords { get; set; }
            public int totalPage { get; set; }
        }

        public class Datum
        {
            public int propertyClass { get; set; }
            public int mainPhotoId { get; set; }
            public bool isPreferred { get; set; }
            public int optOutFromGalleryChanges { get; set; }
            public string countryCode { get; set; }
            public float longitude { get; set; }
            public bool isFirstPage { get; set; }
            public string checkinDate { get; set; }
            public int accuratePropertyClass { get; set; }
            public int reviewCount { get; set; }
            public float latitude { get; set; }
            public string wishlistName { get; set; }
            public int rankingPosition { get; set; }
            public float reviewScore { get; set; }
            public string currency { get; set; }
            public Pricebreakdown priceBreakdown { get; set; }
            public Checkout checkout { get; set; }
            public int ufi { get; set; }
            public string[] photoUrls { get; set; }
            public string[] blockIds { get; set; }
            public string name { get; set; }
            public int position { get; set; }
            public string reviewScoreWord { get; set; }
            public int id { get; set; }
            public string checkoutDate { get; set; }
            public int qualityClass { get; set; }
            public Checkin checkin { get; set; }
            public bool isPreferredPlus { get; set; }
        }

        public class Pricebreakdown
        {
            public Strikethroughprice strikethroughPrice { get; set; }
            public object[] taxExceptions { get; set; }
            public Benefitbadge[] benefitBadges { get; set; }
            public Excludedprice excludedPrice { get; set; }
            public Grossprice grossPrice { get; set; }
        }

        public class Strikethroughprice
        {
            public float value { get; set; }
            public string currency { get; set; }
            public string amountRounded { get; set; }
        }

        public class Excludedprice
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Grossprice
        {
            public string amountRounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Benefitbadge
        {
            public string identifier { get; set; }
            public string text { get; set; }
            public string explanation { get; set; }
            public string variant { get; set; }
        }

        public class Checkout
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Checkin
        {
            public string untilTime { get; set; }
            public string fromTime { get; set; }
        }

    }
}
