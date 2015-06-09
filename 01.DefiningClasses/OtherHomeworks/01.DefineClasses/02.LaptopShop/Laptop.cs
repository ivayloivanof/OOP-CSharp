using System;
using System.Text;


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
    private Battery batt;

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model value cannot be empty!");
            }
            this.model = value;
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative number!");
            }
            this.price = value;
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Manufacturer value cannot be empty!");
            }
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Processor value cannot be empty!");
            }
            this.processor = value;
        }
    }
    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Ram must be > 0");
            }
            this.ram = value;
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Graphics card value cannot be empty!");
            }
            this.graphicsCard = value;
        }
    }
    public int Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("HDD must be > 0");
            }
            this.hdd = value;
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Screen value cannot be empty!");
            }
            this.screen = value;
        }
    }
    public Battery Batt
    {
        get
        {
            return this.batt;
        }
        set
        {
            this.batt = value;
        }
    }

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }
    public Laptop(string model, decimal price, Battery battery)
    {
        this.Model = model;
        this.Price = price;
        this.Batt = battery;
    }
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
            result.AppendLine("RAM: " + this.Ram + " GB");
        }
        if (graphicsCard != null)
        {
            result.AppendLine("Graphics Card: " + this.GraphicsCard);
        }
        if (hdd > 0)
        {
            result.AppendLine("HDD: " + this.Hdd + " GB");
        }
        if (screen != null)
        {
            result.AppendLine("Screen: " + this.Screen);
        }
        if (batt.BatteryLife > 0)
        {
            result.AppendLine("Battery: " + this.batt.BatteryModel);
        }
        if (batt.BatteryModel != null)
        {
            result.AppendLine("Battery Life: " + this.batt.BatteryLife + "hours");
        }
        result.AppendLine("Price: " + this.Price + " lv.");
        return result.ToString();

    }

}