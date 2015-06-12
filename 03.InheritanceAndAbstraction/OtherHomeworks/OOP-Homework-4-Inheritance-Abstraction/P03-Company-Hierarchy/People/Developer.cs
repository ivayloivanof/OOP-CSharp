using P03_Company_Hierarchy.Projects;
using System.Text;

namespace P03_Company_Hierarchy.People
{
    public class Developer : RegularEmployee
    {
        private Project[] projects;

        public Developer(int id, string firstName, string lastName, decimal salary, string department, Project[] projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }
        public Project[] Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Developer with ID: {0} - {1} {2}, who has the following projects: ", this.Id, this.FirstName, this.LastName));
            int index = 1;
            foreach (Project prj in this.Projects)
            {
                info.AppendLine(string.Format("Project {0}: {1} State: {2}", index, prj.ProjectName, prj.State));
                index++;
            }

            return info.ToString();
        }
    }
}