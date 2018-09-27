namespace EcoBeeApiWrapper.Models
{
    public class Weather
    {
        public string Timestamp { get; set; }
        public string WeatherStation { get; set; }
        public WeatherForecast[] Forecasts { get; set; }
    }
}
