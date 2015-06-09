using System;
using System.Collections.Generic;

namespace CompanyHierarchy.Class.Employee.RegularEmployer
{
    using Interfaces;
    class Developer : Employee, IDeveloper
    {
        private List<string> projects;
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private string state;    //{ open,closed };

        public bool CloseProject(string projectName)
        {
            return true;
        }
    }
}
