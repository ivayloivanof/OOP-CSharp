using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Class.Employee.RegularEmployer
{
    using Interfaces;
    class Developer : Employee, IDeveloper
    {
        private List<string[]> projects = new List<string[]>();
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private string state;    //{ open,closed };

        public Developer(string firstName, string lastName, decimal salary, int id = 1, string department = "Production")
            : base(firstName, lastName, salary, id, department)
        {
            department = "Production";
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.Salary = salary;
            this.Department = department;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Project name is empty");
                for (int i = 0; i < this.projects.Count; i++)
                {
                    if (this.projects[i][0].Contains(value))
                    {
                        throw new ArgumentException("This project is created, Cannot be created with this name!");
                    }
                }
                this.projectName = value.Trim();
            }
        }
        public DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                DateTime date;
                DateTime.TryParse(value.ToString(), out date);
                this.projectStartDate = date;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = "Empty";
                this.details = value;
            }
        }
        public string State
        {
            get { return this.state; }
            set
            {
                if (value != "open" && value != "closed")
                    throw new ArgumentException("Project state is wrong");
                this.state = value.Trim();
            }
        }

        public void CreateProject(string projectName, DateTime projectStartDate, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = "open";

            string[] project = new string[4];
            project[0] = this.ProjectName;
            project[1] = this.ProjectStartDate.ToString();
            project[2] = this.Details;
            project[3] = this.State;

            projects.Add(project);
        }

        public bool CloseProject(string projectName)
        {
            for (int i = 0; i < this.projects.Count; i++)
            {
                if (this.projects[i][0].Contains(projectName))
                {
                    this.projects[i][3] = "closed";
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            Console.WriteLine("First name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Salary: {0}", this.Salary);
            Console.WriteLine("Department: {0}", this.Department);
            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < this.projects.Count; i++)
            {
                Console.WriteLine("Project name: {0}", this.projects[i][0]);
                Console.WriteLine("Project start date: {0}", this.projects[i][1]);
                Console.WriteLine("Project details: {0}", this.projects[i][2]);
                Console.WriteLine("Project state: {0}", this.projects[i][3]);
                Console.WriteLine(new string('-', 30));
            }
            return string.Empty;
        }
    }
}
