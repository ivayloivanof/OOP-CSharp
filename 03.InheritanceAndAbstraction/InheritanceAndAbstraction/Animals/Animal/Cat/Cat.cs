using System;

namespace Interfaces.Animal.Cat
{
    class Cat : Animal
    {
        public override int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 15)
                    throw new ArgumentOutOfRangeException("Impossible cat");
                this.age = value;
            }
        }

        public override char Gender
        {
            get { return this.gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentException("Impossible sex");
                }
            }
        }

        protected override void CreateAnimal(string animal, int age, char gender)
        {
            this.Name = animal;
            this.Age = age;
            this.Gender = gender;
            this.Kind = "cat";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am a cat and meowing!");
        }

        public override string Kind
        {
            get { return this.kind; }
            set { this.kind = value; }
        }

        public Cat(string animal, int age, char gender)
        {
            CreateAnimal(animal, age, gender);
        }
    }
}
