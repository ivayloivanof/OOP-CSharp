using System;
using System.Collections.Generic;

class Computer
{
    private string name;
    private List<string> component;
    private decimal price;
    private List<Component> components = new List<Component>();

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "Argument is null or empty!");
            }
            this.name = value;
        }
    }
    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value", "This argument is OutOfRange. Value > 0");
            }
            this.price = value;
        }
    }
    public List<string> Components
    {
        get { return this.component; }
        set
        {
            if (value.Count == 0)
            {
                throw new ArgumentNullException("value", "This list is empty");
            }
            this.component = value;
        }
    }

    public Computer(string name, List<string> component)
    {
        this.Name = name;
        this.Components = component;
        this.InitializingComponent(this.component);
        this.Price = TotalPrice();
    }

    private void InitializingComponent(List<string> list)
    {
        
        for (int i = 0; i < list.Count; i++)
        {
            string[] line = list[i].Split(',');
            Component components = new Component(line[0], line[1], Convert.ToDecimal(line[2]));
            this.components.Add(components);
        }
    }

    public decimal TotalPrice()
    {
        decimal sum = 0m;
        for (int i = 0; i < this.components.Count; i++)
        {
            sum += this.components[i].Price;
        }
        return sum;
    }

    public override string ToString()
    {
        Console.WriteLine("Computer name = {0}", this.name);
        for (int i = 0; i < this.component.Count; i++)
        {
            string[] line = this.component[i].Split(',');
            Console.WriteLine("Name of component: {0} | Price of component: {1}", line[0].Trim(), line[2].Trim());
        }
        Console.WriteLine("Sum of prices: {0}", this.price);
        return string.Empty;
    }
}