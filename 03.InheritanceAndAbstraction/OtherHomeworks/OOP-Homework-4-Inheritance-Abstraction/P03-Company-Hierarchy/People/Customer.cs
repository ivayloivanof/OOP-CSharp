namespace P03_Company_Hierarchy.People
{
    public class Customer : Person
    {
        private double netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, double netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount { 
            get; 
            set; 
        }

        public override string ToString()
        {
            return string.Format("Customer with ID: {0} - {1} {2}, Net Purchase Amount: {3}",
                                                this.Id, this.FirstName, this.LastName, this.NetPurchaseAmount);
        }
    }
}