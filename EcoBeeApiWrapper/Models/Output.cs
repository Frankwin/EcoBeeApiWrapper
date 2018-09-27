using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Output
    {
        public string Name { get; set; }
        public int Zone { get; set; }
        public int OutputId { get; set; }
        public OutputType Type { get; set; }
        public bool SendUpdate { get; set; }
        public bool ActiveClosed { get; set; }
        public int ActivationTime { get; set; }
        public int DeactivationTime { get; set; }
    }
}
