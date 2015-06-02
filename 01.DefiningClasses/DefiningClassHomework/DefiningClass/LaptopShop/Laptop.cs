using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private double price;

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value != null && value.Trim() != String.Empty)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("This is not valid model for laptop!");
            }
        }
    }
    public double Price
    {
        get { return this.price; }
        set
        {
            if (value > 0)
            {
                this.price = value;
            }
            else
            {
                throw new Exception("This is not valid value for double numbers!");
            }
        }
    }
    public string Manufacturer {
        get { return this.manufacturer; }
        set
        {
            if (value != null)
            {
                this.manufacturer = value;
            }
        }
    }
    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value != null)
            {
                this.processor = value;
            }
        }
    }
    public string Ram
    {
        get { return this.ram; }
        set
        {
            if (value != null)
            {
                this.ram = value;
            }
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value != null)
            {
                this.graphicsCard = value;
            }
        }
    }
    public string HDD
    {
        get { return this.hdd; }
        set
        {
            if (value != null)
            {
                this.hdd = value;
            }
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set {
            if (value != null)
            {
                this.screen = value;
            }
        }
    }
    
    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
        PrintInfo();
    }

    public Laptop(  string model, double price, string manufacturer = null
                    , string processor = null, string ram = null, string graphicsCard = null
                    , string hdd = null, string screen = null, string battery = null
                    , string baterryLife = null)
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        BatteryInfo batteryInfo = new BatteryInfo(battery, baterryLife);
        PrintInfo("full");
    }

    private void PrintInfo(string information)
    {
        Console.WriteLine("model {0}", this.model);
        Console.WriteLine("manufacturer {0}", this.manufacturer);
        Console.WriteLine("processor {0}", this.processor);
        Console.WriteLine("RAM {0}", this.ram);
        Console.WriteLine("graphics card {0}", this.graphicsCard);
        Console.WriteLine("HDD {0}", this.hdd);
        Console.WriteLine("screen {0}", this.screen);
        Console.WriteLine("battery {0}");
        Console.WriteLine("battery life {0}");
        Console.WriteLine("price {0:f2}lv", this.price);
    }

    private void PrintInfo()
    {
        Console.WriteLine("model {0}", this.model);
        Console.WriteLine("price {0:f2}lv", this.price);
    }
}