using System;

namespace RobotFactory
{
    public abstract class Robot
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; } // Battery life in hours
        public string SoftwareVersion { get; set; }

        public Robot(string modelName, double batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        // Prototype method for cloning
        public abstract Robot Clone();

        // Helper method to display robot details
        public abstract void DisplayDetails();
    }
}