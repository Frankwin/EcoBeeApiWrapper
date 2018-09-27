using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class WeatherForecast
    {
        public WeatherSymbol WeatherSymbol { get; set; }
        public string DateTime { get; set; }
        public string Condition { get; set; }
        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public int RelativeHumidity { get; set; }
        public int DewPoint { get; set; }
        public int Visibility { get; set; }
        public int WindSpeed { get; set; }
        public int WindGust { get; set; }
        public string WindDirection { get; set; }
        public int WindBearing { get; set; }
        public int PoP { get; set; }
        public int TempHigh { get; set; }
        public int TempLow { get; set; }
        public CloudCover Sky { get; set; }
    }
}
