using System;
using System.Collections.Generic;

namespace OOP_Inheritance_Demo
{
    // -------------------------------
    public class Computer
    {
        private static int totalComputers = 0;
        private static int poweredOnComputers = 0;

        public string IpAddress { get; set; }
        public string Brand { get; set; }
        public string OperatingSystem { get; set; }
        public bool IsPoweredOn { get; private set; }

        public Computer(string ip, string brand, string os)
        {
            IpAddress = ip;
            Brand = brand;
            OperatingSystem = os;
            IsPoweredOn = false;
            totalComputers++;
        }

        public virtual void PowerOn()
        {
            if (!IsPoweredOn)
            {
                IsPoweredOn = true;
                poweredOnComputers++;
                Console.WriteLine($"Computer {IpAddress} is powering on...");
            }
        }

        public virtual void PowerOff()
        {
            if (IsPoweredOn)
            {
                IsPoweredOn = false;
                poweredOnComputers--;
                Console.WriteLine($"Computer {IpAddress} is shutting down...");
            }
        }

        public static int GetTotalComputers() => totalComputers;
        public static int GetPoweredOnCount() => poweredOnComputers;
    }

    // -------------------------------
    public class Server : Computer
    {
        public string ServerRole { get; set; }

        public Server(string ip, string brand, string os, string role)
            : base(ip, brand, os)
        {
            ServerRole = role;
        }
    }

    // -------------------------------
    public class GraphicsWorkstation : Computer
    {
        public string GraphicsSoftware { get; set; }

        public GraphicsWorkstation(string ip, string brand, string os, string software)
            : base(ip, brand, os)
        {
            GraphicsSoftware = software;
        }
    }

    // -------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> network = new List<Computer>();

            Server webServer = new Server("192.168.1.10", "Dell", "Linux", "Web Server");
            Computer officePc = new Computer("192.168.1.11", "HP", "Windows");
            GraphicsWorkstation designPc =
                new GraphicsWorkstation("192.168.1.12", "Lenovo", "Windows", "Photoshop");

            network.Add(webServer);
            network.Add(officePc);
            network.Add(designPc);

            Console.WriteLine($"Total computers in network: {Computer.GetTotalComputers()}");
            Console.WriteLine();

            foreach (Computer comp in network)
                comp.PowerOn();

            Console.WriteLine("\n--- Active Computers ---");
            foreach (Computer comp in network)
            {
                Console.Write($"{comp.IpAddress}\t{comp.OperatingSystem}\t{comp.Brand}");

                if (comp is Server server)
                    Console.WriteLine($"\t{server.ServerRole}");
                else if (comp is GraphicsWorkstation gs)
                    Console.WriteLine($"\t{gs.GraphicsSoftware}");
                else
                    Console.WriteLine();
            }
        }
    }
}
