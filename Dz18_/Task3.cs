using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz18_
{
    public class Device
    {
        public string Name { get; set; }
        public string Vendor { get; set; }
        public decimal Price { get; set; }

        public static List<Device> CreateDevicesList()
        {
            List<Device> devices = new List<Device>();
            Console.Write("\nName: ");
            string name = Console.ReadLine();
            Console.Write("Vendor: ");
            string vendor = Console.ReadLine();
            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Device device = new Device
            {
                Name = name,
                Vendor = vendor,
                Price = price
            };

            devices.Add(device);
            Console.WriteLine();

            return devices;
        }

        public static List<Device> GetDifference(List<Device> devices1, List<Device> devices2)
        {
            return devices1.FindAll(d1 => !devices2.Exists(d2 => d1.Vendor == d2.Vendor));
        }

        public static List<Device> GetIntersection(List<Device> devices1, List<Device> devices2)
        {
            return devices1.FindAll(d1 => devices2.Exists(d2 => d1.Vendor == d2.Vendor));
        }

        public static List<Device> GetUnion(List<Device> devices1, List<Device> devices2)
        {
            List<Device> unionList = new List<Device>(devices1);
            unionList.AddRange(devices2);
            return unionList;
        }

        public static void PrintDevices(List<Device> devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine($"Name: {device.Name}, Vendor: {device.Vendor}, Price: {device.Price}");
            }
        }
    }
}
