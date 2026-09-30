using System;

namespace RobotFactory
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(string modelName, double batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override Robot Clone()
        {
            // Performs a shallow copy of the object
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Service Robot] Model: {ModelName} | Battery: {BatteryCapacity}h | Software: {SoftwareVersion} | Task: {ServiceTask}");
        }
    }
}