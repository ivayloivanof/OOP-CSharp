using System;
using System.Text;

namespace _02.Laptop_Shop
{
    class Laptop
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private string screen;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;

        }

        public Laptop(string model, decimal price, Battery battery)
        {
            this.Model = model;
            this.Price = price;
            this.Battery = battery;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model cannot be empty!");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative!");
                }
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The manufacturer cannot be emtpy!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Processor cannot be emptyu!");
                }
                this.processor = value;
            }
        }

        public int RAM
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The RAM cannot be negative!");
                }
                this.ram = value;
            }
        }

        public string GraphicsCards
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Graphics Card cannot be empty!");
                }
                this.graphicsCard = value;
            }
        }

        public int HDD
        {
            get { return this.hdd; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HDD cannot be negative!");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen cannot be empty!");
                }
                this.screen = value;
            }
        }

        public Battery Battery { get; set; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop description:");
            result.AppendLine("Model: " + this.Model);

            if (manufacturer != null)
            {
                result.AppendLine("Manufacturer: " + this.Manufacturer);
            }
            if (processor != null)
            {
                result.AppendLine("Processor: " + this.Processor);
            }
            if (ram > 0)
            {
                result.AppendLine("RAM: " + this.RAM + " GB");
            }
            if (graphicsCard != null)
            {
                result.AppendLine("Graphics Card: " + this.GraphicsCards);
            }
            if (hdd > 0)
            {
                result.AppendLine("HDD: " + this.HDD + " GB");
            }
            if (screen != null)
            {
                result.AppendLine("Screen: " + this.Screen);
            }
            if (Battery.BatteryLife > 0)
            {
                result.AppendLine("Battery: " + this.Battery.BatteryModel);
            }
            if (Battery.BatteryModel != null)
            {
                result.AppendLine("Battery Life: " + this.Battery.BatteryLife + "hours");
            }
            result.AppendLine("Price: " + this.Price + " lv.");
            return result.ToString();

        }
    }
}
