using Newtonsoft.Json;

namespace EcoBeeApiWrapper.Models
{
    public class Page
    {
        [JsonProperty("page")]
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
    }
}
