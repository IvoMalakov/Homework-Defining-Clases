using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace _03.PC_Catalog
{
    public class Computer
    {
        private string name;
        private List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You must have a name and your name can not be empty");
                }

                this.name = value;
            } 
        }

        public decimal Price
        {
            get { return CalculatePrice(this); }
        }

        public List<Component> Components
        {
            get { return this.components; }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Your computer must have at least one component");
                }

                this.components = value;
            }
        }

        private decimal CalculatePrice(Computer computer)
        {
            var components = computer.Components;
            decimal price = components.Sum(component => component.Price);

            return price;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("Computer's name: {0}, ", this.name));
            foreach (var component in components)
            {
                result.AppendLine(String.Format("Components name: {0}, Component's price: {1} lv., Some details: {2}",
                    component.Name, component.Price, string.IsNullOrWhiteSpace(component.Details)
                        ? "no details for this component"
                        : component.Details));
            }

            result.AppendLine(String.Format("The total price of your computer with all components is: {0} lv.",
                this.Price));

            return result.ToString();
        }
    }
}
