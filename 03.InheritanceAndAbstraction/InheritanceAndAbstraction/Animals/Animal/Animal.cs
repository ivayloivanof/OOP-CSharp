using System;
using Interfaces;

namespace Animal
{
    abstract class Animal : ISoundProducible
    {
        private string name;
        protected string kind;
        protected int age;
        protected char gender;

        protected string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    throw new ArgumentNullException();
                this.name = value.Trim();
            }
        }

        abstract public int Age { get; set; }
        abstract public char Gender { get; set; }
        protected abstract void CreateAnimal(string animal, int age, char gender);
        abstract public void ProduceSound();
        abstract public string Kind { get; set; }
    }
}
