using System;

namespace RobotFactory
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(string modelName, double batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Industrial Robot] Model: {ModelName} | Battery: {BatteryCapacity}h | Software: {SoftwareVersion} | Task: {IndustrialTask}");
        }
    }
}