using CompanyHierarchy.Interfaces;
namespace CompanyHierarchy.Class
{
    class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName, int id = 1)
        {
            this.FirstName = firstName.Trim();
            this.LastName = lastName.Trim();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
