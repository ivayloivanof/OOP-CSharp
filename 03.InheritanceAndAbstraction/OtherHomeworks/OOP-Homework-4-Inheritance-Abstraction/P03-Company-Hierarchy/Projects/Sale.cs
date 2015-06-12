using System;

namespace P03_Company_Hierarchy.Projects
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return string.Format("Product - Name: {0}, Price: {1} BGN", this.ProductName, this.Price);
        }
    }
}