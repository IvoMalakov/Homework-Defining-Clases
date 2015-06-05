using System;

namespace _02.LaptopShop
{
    public class Battery
    {
        private string batteryName;
        private double? batteryLife;

        public Battery(string batteryName, double? batteryLife)
        {
            this.BatteryName = batteryName;
            this.BatteryLife = batteryLife;
        }

        public Battery(string batteryName) : this(batteryName, null)
        {
        }

        public Battery(double? batteryLife) : this(null, batteryLife)
        {
        }

        public Battery() : this(null, null)
        {
        }

        public string BatteryName
        {
            get { return this.batteryName; }

            set
            {
                if (value != null && value == " ".Trim())
                {
                    throw new ArgumentException("Your battery model can not be empty");
                }

                this.batteryName = value;
            }
        }

        public double? BatteryLife
        {
            get { return this.batteryLife; }

            set
            {
                if (value != null && value < 0.00)
                {
                    throw new ArgumentException("Your price can not be negative");
                }

                this.batteryLife = value;
            }
        }
    }
}
