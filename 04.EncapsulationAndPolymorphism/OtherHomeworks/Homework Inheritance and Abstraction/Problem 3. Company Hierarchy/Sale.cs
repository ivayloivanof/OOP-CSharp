using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public class Sale
    {
        private string productname;
        private DateTime date;
        private double price;
        public Sale(string productname, DateTime date, double price)
        {
            this.Productname = productname;
            this.Date = date;
            this.Price = price;
        }

        public string Productname
        {
            get { return this.productname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name of product. Please entered correct!");
                }
                this.productname = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("Invalid date!");
                }
                this.date = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Invalid price!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name of product: {0}, Date: {1}, Price: {2}", this.Productname, this.Date, this.Price);
        }
    }
}
