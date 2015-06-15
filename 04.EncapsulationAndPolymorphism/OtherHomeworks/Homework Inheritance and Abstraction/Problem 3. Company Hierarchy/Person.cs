using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company_Hierarchy
{
    public abstract class Person:IPerson
    {
        private string id;
        private string firstname;
        private string lastname;
        public Person(string id, string firstname, string lastname)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
        public string Id 
        {
            get { return this.id; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw  new ArgumentException("Invalid Id!");
                }
                this.id = value;
            }
        }

        public string Firstname
        {
            get { return this.firstname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Firstname! Please enterd correct.");
                }
                this.firstname = value;
            }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Lastname! Please enterd correct.");
                }
                this.Lastname = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Id {0} Firstname: {1} Lastname: {2}",this.Id,this.Firstname,this.Lastname);
        }
    }
}
