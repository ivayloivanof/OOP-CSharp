using System;

namespace P03_Company_Hierarchy.Projects
{
    public class Project
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private string state;

        public Project(string projectName, DateTime startDate, string details, string state)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }

        public DateTime StartDate { get; set; }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public string State
        {
            get { return this.state; }
            set
            {
                if (value != "open" && value != "closed")
                {
                    throw new ArgumentException("State must be open or closed.");
                }

                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = "closed";
        }

        public override string ToString()
        {
            return string.Format("Project - Name: {0}, Start Date: {1}, State: {2}", this.ProjectName, this.StartDate, this.State);
        }
    }
}