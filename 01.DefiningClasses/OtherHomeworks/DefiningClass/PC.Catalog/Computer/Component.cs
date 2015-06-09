class Component
{
    private string name;
    private string details;
    private decimal price;

    public string Name { get; set; }
    public string Details { get; set; }
    public decimal Price { get; set; }

    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }
}