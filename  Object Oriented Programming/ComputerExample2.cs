// OOP Concepts in C# - Device Example
using System;
using System.Collections.Generic;

namespace OOP_Device_Example
{
    class Device
    {
        private string _deviceName;
        private string _ipAddress;
        private string _os;
        private static int _deviceCount = 0;

        public Device(string name, string os)
        {
            _deviceName = name;
            _os = os;
            _deviceCount++;
        }

        public Device()
        {
            _deviceCount++;
        }

        public string DeviceName
        {
            get { return _deviceName; }
            set { _deviceName = value; }
        }

        public string IPAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        public string OS
        {
            get { return _os; }
            set { _os = value; }
        }

        // Static methods
        public static int GetDeviceCount()
        {
            return _deviceCount;
        }

        public static string GenerateIPPart()
        {
            Random rnd = new Random();
            return rnd.Next(10, 200).ToString();
        }

        public void AssignIP()
        {
            IPAddress = "192.168.1." + GenerateIPPart();
        }
    }

    class Program
    {
        static void RemoveDevice(List<Device> network, string deviceName)
        {
            for (int i = 0; i < network.Count; i++)
            {
                if (network[i].DeviceName == deviceName)
                {
                    network.RemoveAt(i);
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            List<Device> network = new List<Device>();

            Device router = new Device("Router", "Linux");
            router.IPAddress = "192.168.1.1";
            network.Add(router);

            for (int i = 1; i <= 4; i++)
            {
                Device d = new Device("Device" + i, "Windows");
                d.AssignIP();
                network.Add(d);
            }

            Console.WriteLine("Devices in network:");
            foreach (Device d in network)
            {
                Console.WriteLine($"{d.DeviceName} - {d.IPAddress} - {d.OS}");
            }

            Console.WriteLine("\nRemoving Device2...");
            RemoveDevice(network, "Device2");

            Console.WriteLine("\nUpdated network:");
            foreach (Device d in network)
            {
                Console.WriteLine($"{d.DeviceName} - {d.IPAddress}");
            }

            Console.WriteLine($"\nTotal devices created: {Device.GetDeviceCount()}");
        }
    }
}