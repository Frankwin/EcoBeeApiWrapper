using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class State
    {
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public SensorStateType Type { get; set; }
        public Action[] Actions { get; set; }
    }
}
