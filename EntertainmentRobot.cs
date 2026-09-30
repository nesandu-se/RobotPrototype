using System;

namespace RobotFactory
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(string modelName, double batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Entertainment Robot] Model: {ModelName} | Battery: {BatteryCapacity}h | Software: {SoftwareVersion} | Feature: {EntertainmentFeature}");
        }
    }
}