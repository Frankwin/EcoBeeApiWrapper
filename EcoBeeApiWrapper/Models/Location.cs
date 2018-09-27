namespace EcoBeeApiWrapper.Models
{
    public class Location
    {
        public int TimeZoneOffsetMinutes { get; set; }
        public string TimeZone { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ProvinceState { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string MapCoordinates { get; set; }
    }
}
