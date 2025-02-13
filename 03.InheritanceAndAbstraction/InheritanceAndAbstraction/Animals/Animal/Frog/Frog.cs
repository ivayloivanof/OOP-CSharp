﻿using System;

namespace Interfaces.Animal.Frog
{
    class Frog : Animal
    {
        public override int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException("Impossible frog");
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
            this.Kind = "frog";
        }

        public Frog(string animal, int age, char gender)
        {
            CreateAnimal(animal, age, gender);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am a frog and gobble!");
        }

        public override string Kind
        {
            get { return this.kind; }
            set { this.kind = value; }
        }
    }
}
