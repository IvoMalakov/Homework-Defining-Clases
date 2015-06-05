using System;
using System.Collections.Generic;

namespace _02.LaptopShop
{
    public class LaptopShop
    {
        public static void Main()
        {
            List<Laptop> laptops = new List<Laptop>();

            int n = 0;
            bool validN = false;

            while (validN == false || n < 1)
            {
                Console.WriteLine("Add how much laptops you want to have: ");
                string tryN = Console.ReadLine();
                validN = int.TryParse(tryN, out n);

                if (validN == false || n < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong number. You must have atleast one lapop");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the model of the [{0}] laptop", i);
                string model = Console.ReadLine();
                Console.WriteLine("Enter the price of the [{0}] laptop", i);
                decimal price = decimal.Parse(Console.ReadLine());

                var batt = new Battery();
                Laptop laptop = new Laptop(model, price, batt);

                Console.WriteLine("If you want please add the manufacturer of your laptop");
                string manufacturer = Console.ReadLine();
                bool manufacturerIsNull = manufacturer == "" ? true : false;
                manufacturer = manufacturerIsNull ? null : manufacturer;

                if (manufacturer != null)
                {
                    laptop.Manufacturer = manufacturer;
                }

                Console.WriteLine("If you want please add the processor of your laptop");
                string processor = Console.ReadLine();
                bool processorIsNull = processor == "" ? true : false;
                processor = processorIsNull ? null : manufacturer;

                if (processor != null)
                {
                    laptop.Processor = processor;
                }

                Console.WriteLine("If you want please add the RAM memmory of your laptop");
                string ramAsString = Console.ReadLine();
                int? ram;

                if (ramAsString == "")
                {
                    ram = null;
                }

                else
                {
                    ram = int.Parse(ramAsString);
                }

                if (ram != null)
                {
                    laptop.Ram = ram;
                }

                Console.WriteLine("If you want please add your gaphics card");
                string graphicsCard = Console.ReadLine();

                if (graphicsCard == "")
                {
                    graphicsCard = null;
                }

                if (graphicsCard != null)
                {
                    laptop.GraphicsCard = graphicsCard;
                }

                Console.WriteLine("If you want please add the HDD size of your laptop");
                string hddAsString = Console.ReadLine();
                int? hdd;

                if (hddAsString == "")
                {
                    hdd = null;
                }

                else
                {
                    hdd = int.Parse(hddAsString);
                }

                if (hdd != null)
                {
                    laptop.HDD = hdd;
                }

                Console.WriteLine("If you want please add your screan parameters");
                string screan = Console.ReadLine();

                if (screan == "")
                {
                    screan = null;
                }

                if (screan != null)
                {
                    laptop.Screan = screan;
                }

                Console.WriteLine("If you want please add your battery model");
                string battery = Console.ReadLine();

                if (battery == "")
                {
                    battery = null;
                }

                if (battery != null)
                {
                    laptop.Batt.BatteryName = battery;
                }

                Console.WriteLine("If you want please add your battery's life in hours: ");
                string batteryLifeAsString = Console.ReadLine();
                double? batteryLife;

                if (batteryLifeAsString == "")
                {
                    batteryLife = null;
                }

                else
                {
                    batteryLife = double.Parse(batteryLifeAsString);
                }

                if (batteryLife != null)
                {
                    laptop.Batt.BatteryLife = batteryLife;
                }

                laptops.Add(laptop);
            }

            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop);
            }
        }
    }
}
