using System;

namespace RobotFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Robotic Factory System - Prototype Pattern Demonstration ===\n");

            // Step 1: Create base prototype models
            ServiceRobot baseServiceRobot = new ServiceRobot("HospitalityBot-A1", 12.0, "v1.0.0", "Patient Healthcare Assistance");
            IndustrialRobot baseIndustrialRobot = new IndustrialRobot("FactoryWelder-X", 24.0, "v2.0.0", "Automotive Welding Automation");
            EntertainmentRobot baseEntertainmentRobot = new EntertainmentRobot("ParkHost-3000", 8.0, "v1.2.0", "Theme Park Crowd Interaction");

            Console.WriteLine("--- Original Base Prototype Models ---");
            baseServiceRobot.DisplayDetails();
            baseIndustrialRobot.DisplayDetails();
            baseEntertainmentRobot.DisplayDetails();
            Console.WriteLine();

            // Step 2: Clone and customize for Customer Order 1
            ServiceRobot customServiceRobot = (ServiceRobot)baseServiceRobot.Clone();
            customServiceRobot.BatteryCapacity = 18.0;
            customServiceRobot.SoftwareVersion = "v1.1.0";

            // Step 3: Clone and customize for Customer Order 2
            IndustrialRobot customIndustrialRobot = (IndustrialRobot)baseIndustrialRobot.Clone();
            customIndustrialRobot.SoftwareVersion = "v2.1.0";
            customIndustrialRobot.IndustrialTask = "Heavy Sheet Assembly";

            // Step 4: Clone and customize for Customer Order 3
            EntertainmentRobot customEntertainmentRobot = (EntertainmentRobot)baseEntertainmentRobot.Clone();
            customEntertainmentRobot.BatteryCapacity = 14.0;

            Console.WriteLine("--- Customized Cloned Robots for Customer Orders ---");
            customServiceRobot.DisplayDetails();
            customIndustrialRobot.DisplayDetails();
            customEntertainmentRobot.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("--- Verifying Original Base Prototypes Remain Intact ---");
            baseServiceRobot.DisplayDetails();
            baseIndustrialRobot.DisplayDetails();
            baseEntertainmentRobot.DisplayDetails();
        }
    }
}