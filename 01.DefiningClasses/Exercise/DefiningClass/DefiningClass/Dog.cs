using System;

namespace DefiningClass
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public Dog() : this(null, null)
        {
            
        }

        //public Dog() : 

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bauuuuuu!", this.Name ?? "[unnamed dog]", this.Breed ?? "[uncnow breed]");
        }
    }
}
