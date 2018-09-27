using System;
using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class RuntimeSensorMetaData
    {
        public string SensorId { get; set; }
        public string SensorName { get; set; }
        public RuntimeSensorType SensorType { get; set; }
        public SensorUsage SensorUsage { get; set; }

        public string GetRuntimeSensorTypeUnits(RuntimeSensorType sensorType)
        {
            switch (sensorType)
            {
                case RuntimeSensorType.Co2:
                    return "ppm";
                case RuntimeSensorType.CtClamp:
                case RuntimeSensorType.Plug:
                    return "Wh";
                case RuntimeSensorType.DryContact:
                    return "Binary";
                case RuntimeSensorType.Humidity:
                    return "%RH";
                case RuntimeSensorType.Temperature:
                    return "F";
                default:
                    throw new ArgumentOutOfRangeException(nameof(sensorType), "The SensorType was unknown");
            }
        }
    }
}
