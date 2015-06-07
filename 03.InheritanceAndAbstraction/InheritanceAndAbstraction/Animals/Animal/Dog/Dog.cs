using System;

namespace Animal.Dog
{
    class Dog : Animal
    {
        protected override int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 18)
                    throw new ArgumentOutOfRangeException("Impossible dog");
                this.age = value;
            }
        }

        protected override char Gender
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
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am a dog and barking!");
        }

        public Dog(string animal, int age, char gender)
        {
            CreateAnimal(animal, age, gender);
        }
    }
}
