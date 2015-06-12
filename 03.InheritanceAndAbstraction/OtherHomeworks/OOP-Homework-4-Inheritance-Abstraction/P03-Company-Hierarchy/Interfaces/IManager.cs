using P03_Company_Hierarchy.People;

namespace P03_Company_Hierarchy.Interfaces
{
    interface IManager
    {
        Employee[] Employees { get; set; }
    }
}