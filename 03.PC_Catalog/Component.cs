using System;

namespace _03.PC_Catalog
{
    public class Component
    {
        private string name;
        private decimal price;
        private string details;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price) : this(name, null, price)
        {
            
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Your name can not be empty");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }

            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentException("Your price can not be negative");
                }

                this.price = value;
            }
        }

        public string Details { get; set; }
    }
}
