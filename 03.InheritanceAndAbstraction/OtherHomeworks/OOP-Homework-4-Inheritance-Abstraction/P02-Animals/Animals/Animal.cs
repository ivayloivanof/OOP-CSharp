using P02_Animals.Interfaces;
using System;

namespace P02_Animals
{
    public abstract class Animal: ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public abstract void ProduceSound();
    }
}