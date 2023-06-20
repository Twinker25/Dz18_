namespace Dz18_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nEnter task (1 - 3): ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter size of array: ");
                        int size = int.Parse(Console.ReadLine());
                        int[] arr = new int[size];
                        Console.WriteLine("Array: ");
                        Random r = new Random();
                        for (int i = 0; i < size; i++)
                        {
                            arr[i] = r.Next(1, 100);
                            Console.WriteLine(arr[i]);
                        }

                        CustomNumberComparer.SortByDigitSum(arr);
                        Console.WriteLine("Sorted array:");
                        foreach (int number in arr)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    case 2:
                        string[] arr1 = { "Ukraine", "Poland", "USA", "Germany", "France" };
                        string[] arr2 = { "France", "Germany", "Italy", "China", "Ukraine" };

                        var difference = arr1.Except(arr2);
                        Console.WriteLine("\nDifference:");
                        foreach (string country in difference)
                        {
                            Console.WriteLine(country);
                        }

                        var intersection = arr1.Intersect(arr2);
                        Console.WriteLine("\nIntersection:");
                        foreach (string country in intersection)
                        {
                            Console.WriteLine(country);
                        }

                        var union = arr1.Union(arr2);
                        Console.WriteLine("\nMerging:");
                        foreach (string country in union)
                        {
                            Console.WriteLine(country);
                        }

                        var distinct = arr1.Distinct();
                        Console.WriteLine("\nThe contents of the first array without repetitions:");
                        foreach (string country in distinct)
                        {
                            Console.WriteLine(country);
                        }
                        break;
                    case 3:
                        List<Device> device1 = Device.CreateDevicesList();

                        List<Device> device2 = Device.CreateDevicesList();

                        Console.WriteLine("\nDifference of the two lists:");
                        List<Device> dif = Device.GetDifference(device1, device2);
                        Device.PrintDevices(dif);

                        Console.WriteLine("\nIntersection of the two lists:");
                        List<Device> inter = Device.GetIntersection(device1, device2);
                        Device.PrintDevices(inter);

                        Console.WriteLine("\nUnion of the two lists:");
                        List<Device> un = Device.GetUnion(device1, device2);
                        Device.PrintDevices(un);
                        break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
        }
    }
}