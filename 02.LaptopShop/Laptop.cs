using System;

namespace _02.LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int? ram;
        private string graphicsCard;
        private int? hdd;
        private string screan;
        private Battery battery;
        private decimal price;

        public Laptop(string model, string manufacturer, string procesor, int? ram, string graphicsCard, int? hdd,
            string screan, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = procesor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screan = screan;
            this.Batt = battery;
            this.Price = price;
        }

        public Laptop(string model, decimal price, Battery battery) : this(model, null, null, null, null, null,
            null, battery, price)
        {
        }

        public string Model
        {
            get { return this.model; }

            set
            {
                if (string.IsNullOrEmpty(value) || value == " ".Trim())
                {
                    throw new ArgumentNullException("Your must have a model name");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }

            set
            {
                if (value != null && value == " ".Trim())
                {
                    throw new ArgumentException("Your must have a manufacturer name");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }

            set
            {
                if (value != null && value == " ".Trim())
                {
                    throw new ArgumentException("Your processor name can not be empty");
                }

                this.processor = value;
            }
        }

        public int? Ram
        {
            get { return this.ram; }

            set
            {
                if (value != null && value < 1)
                {
                    throw new ArgumentException("You must have at least 1 GB of RAM");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }

            set
            {
                if (value != null && value == " ".Trim())
                {
                    throw new ArgumentException("Your grphics card model can not be empyty");
                }

                this.graphicsCard = value;
            }
        }

        public int? HDD
        {
            get { return this.hdd; }

            set
            {
                if (value != null && value < 1)
                {
                    throw new ArgumentException("Your hdd must be at least 1 GB");
                }

                this.hdd = value;
            }
        }

        public string Screan
        {
            get { return this.screan; }

            set
            {
                if (value != null && value == " ".Trim())
                {
                    throw new ArgumentException("Your screan model can not be empty");
                }

                this.screan = value;
            }
        }

        public Battery Batt { get; set; }

        public decimal Price
        {
            get { return this.price; }

            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentException("Your price can not be negative:");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, Manufacturer: {1}, Processor: {2}, RAM: {3} GB, Graphics card: {4}," +
                                 " HDD: {5} GB SSD, Screen: {6}, Battery: {7}, BatteryLife: {8} hours, Price: {9:F2} lv.",
                this.Model, this.Manufacturer, this.Processor, this.Ram, this.GraphicsCard, this.HDD, this.Screan,
                this.Batt.BatteryName, (object) this.Batt.BatteryLife ?? "uknow", this.Price);
        }
    }
}