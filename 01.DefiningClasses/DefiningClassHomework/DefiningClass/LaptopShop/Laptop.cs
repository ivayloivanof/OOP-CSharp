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
        set { this.manufacturer = value; }
    }
    public string Processor
    {
        get { return this.processor; }
        set { this.processor = value; }
    }
    public string Ram
    {
        get { return this.ram; }
        set { this.ram = value; }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set { this.graphicsCard = value; }
    }
    public string HDD
    {
        get { return this.hdd; }
        set { this.hdd = value; }
    }
    public string Screen
    {
        get { return this.screen; }
        set { this.screen = value;
        }
    }
    
    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
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
    }

}