namespace P03_Company_Hierarchy.People
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, string department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public override string ToString()
        {
            return string.Format("Regular Employee with ID: {0} - {1} {2}, Department: {3}, Salary: {4}",
                                                        this.Id, this.FirstName, this.LastName, this.Department, this.Salary);
        }
    }
}