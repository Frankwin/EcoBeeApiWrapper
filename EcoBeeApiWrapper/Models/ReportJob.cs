using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class ReportJob
    {
        public string JobId { get; set; }
        public JobStatus Status { get; set; }
        public string Message { get; set; }
        public string[] Files { get; set; }
    }
}
