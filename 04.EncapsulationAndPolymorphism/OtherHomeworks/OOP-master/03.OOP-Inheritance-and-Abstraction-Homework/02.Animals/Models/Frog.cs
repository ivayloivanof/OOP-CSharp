﻿using System;

namespace Animals.Models
{
    class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ribbet");
        }
    }
}
