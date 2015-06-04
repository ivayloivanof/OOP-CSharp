using System;

class Book
{
    protected string title;
    protected string author;
    protected decimal price;

    protected string Title
    {
        get { return this.title; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Title is not empty or null!");
            }
            this.title = value.Trim();
        }
    }
    protected string Author
    {
        get { return this.author; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Author not be empty or null!");
            }
            this.author = value.Trim();
        }
    }
    protected virtual decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price can't be negative number!");
            }
            this.price = value;
        }
    }

    public Book(string title, string author, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public override string ToString()
    {
        Console.WriteLine(base.ToString());
        Console.WriteLine(title);
        Console.WriteLine(author);
        Console.WriteLine(price);
        return string.Empty;
    }
}