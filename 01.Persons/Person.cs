using System;

namespace _01.Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (value == " ".Trim() || value == null)
                {
                    throw new ArgumentNullException("You must have a non empty name");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Your age is not valid");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            set
            {
                if (value != null && (value.Length == 0 || !value.Contains("@")))
                {
                    throw new ArgumentException("Wrong email. Your email must contains symbol \"@\" ");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Email: {2}",
                this.Name, this.Age, this.Email ?? " none");
        }
    }
}