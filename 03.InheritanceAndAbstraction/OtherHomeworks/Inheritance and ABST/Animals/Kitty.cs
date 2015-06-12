using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitty:Cat
    {
        
        public Kitty(string name, int age, string gender="female") : base(name, age, gender="female")
        {

        }

        public override string ProduceSound()
        {
            return String.Format("Mau-mau im a female cat :P");
        }

        public override string ToString()
        {
            return string.Format("{0} is on {1} and is {2}", this.Name, this.Age, this.Gender);
        }
    }
}
