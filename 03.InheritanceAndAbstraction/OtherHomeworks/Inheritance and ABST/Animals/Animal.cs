using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal : ISoundProducible
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        abstract public string ProduceSound();

    }
}
