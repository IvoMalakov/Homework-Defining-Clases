using System;
using System.Collections.Generic;

namespace _01.Persons
{
    public class Persons
    {
        public static void Main()
        {
            List<Person> personList = new List<Person>();

            int n = 0;
            bool validN = false;

            while (validN == false || n < 1)
            {
                Console.WriteLine("Add much persons you want to have: ");
                string tryN = Console.ReadLine();
                validN = int.TryParse(tryN, out n);

                if (validN == false || n < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong number. You must have atleast one person");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the name of the [{0}] person", i);
                string personName = Console.ReadLine();
                Console.WriteLine("Enter the age of the [{0}] person", i);
                int personAge = int.Parse(Console.ReadLine());
                
                Person person = new Person(personName, personAge);

                Console.WriteLine("Do you want your person to have a email? Enter \"yes\" or \"no\": ");
                string answer = Console.ReadLine();

                if (answer == "yes" || answer == "YES" || answer == "Yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the email of your person: ");
                    string personEmail = Console.ReadLine();
                    person.Email= personEmail;
                }

                else
                {
                    person.Email = null;
                }

                personList.Add(person);
            }

            foreach (var person in personList)
            {
                Console.WriteLine(person);
            }
        }
    }
}
