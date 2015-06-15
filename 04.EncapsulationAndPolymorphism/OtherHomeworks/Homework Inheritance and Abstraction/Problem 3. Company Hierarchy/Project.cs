using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public class Project
    {
        public enum State
        {
            open,closed
        }

        public Project(string name, DateTime startDate, string details,State status)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.Status = status;
        }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Details { get; set; }
        public State Status{ get; set; }

        public void CloseProject()
        {
            
        }

        public override string ToString()
        {
            return string.Format("");
        }
    }
}
