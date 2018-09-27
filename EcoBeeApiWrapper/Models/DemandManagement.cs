namespace EcoBeeApiWrapper.Models
{
    public class DemandManagement
    {
        public string Date { get; set; }
        public int Hour { get; set; }
        public int[] TempOffsets { get; set; }
    }
}
