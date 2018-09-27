using System;
using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class HouseDetails
    {
        public HouseStyle Style { get; set; }
        public int Size { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfOccupants { get; set; }
        public int Age { get; set; }
        public int WindowEfficiency { get; set; }

        public double GetWindowEfficiencyRValue(int windowEfficiency)
        {
            switch (windowEfficiency)
            {
                case 1:
                    return 0.8;
                case 2:
                    return 0.96;
                case 3:
                    return 1.65;
                case 4:
                    return 2.01;
                case 5:
                    return 2.5;
                case 6:
                    return 1.14;
                case 7:
                    return 1.37;
                default:
                    throw new ArgumentOutOfRangeException(nameof(windowEfficiency), "The value was not within an expected range");
            }
        }
    }
}
