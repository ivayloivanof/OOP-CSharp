using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender="male")
        {
        }

        public override string ProduceSound()
        {
            return String.Format("Mau im a male cat :)");
        }

        public override string ToString()
        {
            return string.Format("{0} is on {1} and is {2}", this.Name, this.Age, this.Gender);
        }
    }
}
