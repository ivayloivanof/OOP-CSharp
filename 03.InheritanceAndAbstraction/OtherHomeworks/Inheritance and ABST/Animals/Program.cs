using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Dog pesho = new Dog("Pesho", 3, "male");
            Frog marin = new Frog("Marin", 2, "female");
            Cat katq = new Cat("Katq", 2, "male");
            Dog gosho = new Dog("Gosho", 3, "female");
            Cat pencho = new Cat("Pehcno", 2, "male");
            Frog sasho = new Frog("Sasho", 1, "male");
            list.Add(pesho);
            list.Add(marin);
            list.Add(katq);
            list.Add(gosho);
            list.Add(pencho);
            list.Add(sasho);
            int count = 1;
            int age = 0;
            Kitty kat=new Kitty("kat",3,"male");
            Console.WriteLine(kat.Gender);

            Dictionary<string,double>ani=new Dictionary<string, double>();
            for (int i = 0; i < list.Count; i++)
            {
                string s = list[i].GetType().ToString();
                age = list[i].Age;
                for (int j = 0; j < list.Count; j++)
                {
                    if (i!=j)
                    {
                        string m = list[j].GetType().ToString();
                        if (m==s)
                        {
                            age += list[j].Age;
                            count++;
                        }
                    }
                }
               
                if (!(ani.ContainsKey(s)))
                {
                   ani.Add(s,age/count); 
                }
                count = 1;
            }
            foreach (var n in ani)
            {
                Console.WriteLine(n.Key+" "+n.Value);
            }
        }
    }
}
