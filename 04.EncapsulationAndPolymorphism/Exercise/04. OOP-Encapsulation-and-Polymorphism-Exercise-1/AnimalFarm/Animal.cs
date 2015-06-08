namespace AnimalFarm
{
    using System;

    public abstract class Animal
    {
        private const int MinAnimalAge = 0;
        private const int MaxAnimalAge = 15;

        private string name;
        protected readonly int age;

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()) || string.IsNullOrWhiteSpace(value.Trim()))
                    throw new ArgumentNullException("Name can not be null, empty or only whitespace!");
                this.name = value.Trim();
            }
        }

        private int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Age cannot be negative.");
                }
            }
        }
        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        public abstract Product ProduceProduct();

        public abstract double GetHumanAge();

        public double CalculateProductPerDay()
        {
            switch (this.age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}

