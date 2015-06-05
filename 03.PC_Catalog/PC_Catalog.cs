using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PC_Catalog
{
    public class PC_Catalog
    {
        public static void Main()
        {
            List<Computer> computerCatalog = new List<Computer>();

            int n = 0;
            bool validN = false;

            while (validN == false || n < 1)
            {
                Console.WriteLine("Add how much computers you want to have in your catalog: ");
                string tryN = Console.ReadLine();
                validN = int.TryParse(tryN, out n);

                if (validN == false || n < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong number. You must have atleast one computer in your cataloge");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the name of the [{0}] computer", i);
                string computerName = Console.ReadLine();
                Console.WriteLine("How many compunents you want to have in your computer: ");
                int numberOfCompunents = int.Parse(Console.ReadLine());
                Console.WriteLine();

                List<Component> components = new List<Component>();

                for (int j = 1; j <= numberOfCompunents; j++)
                {
                    Console.WriteLine("Enter the name of the [{0}] component", j);
                    string componentName = Console.ReadLine();
                    Console.WriteLine("Enter the price of the [{0}] component", j);
                    decimal componentPrice = decimal.Parse(Console.ReadLine());

                    components.Add(new Component(componentName, componentPrice));
                }

                Computer computer = new Computer(computerName, components);
                computerCatalog.Add(computer);
            }

            var sortedComputerCatalog = computerCatalog.OrderBy(computer => computer.Price);

            foreach (var computer in sortedComputerCatalog)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
