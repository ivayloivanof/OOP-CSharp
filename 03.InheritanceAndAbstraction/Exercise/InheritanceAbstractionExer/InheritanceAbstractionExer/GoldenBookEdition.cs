class GoldenBookEdition : Book
{
    protected override decimal Price
    {
        get { return price; }
        set { price = value*1.3m; }
    }

    public GoldenBookEdition(string title, string author, decimal price) : base (title, author, price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }
}