using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Paths3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Path3D somePath3D = new Path3D(new List<Point>());
            Console.WriteLine("What would you like to do ?");
            Console.WriteLine("Read one of the sample paths ? (Press R to choose)...");
            Console.WriteLine("Or create a new path ? (Press N to choose)...");
            ConsoleKeyInfo key;
            bool IsValidCommand = false;
            while (!IsValidCommand)
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.R:
                    {
                        Console.Clear();
                        Console.WriteLine("You have chosen to read one of the sample paths !");
                        Console.Write("Enter the index of the path you want to read [1,5] - ");
                        int choice = int.Parse(Console.ReadLine());
                        if(choice < 1 || choice > 5) throw new Exception("Invalid index of path !");
                        somePath3D = Storage.LoadPath(choice, somePath3D);
                        for (int i = 0; i < somePath3D.path.Count; i++)
                        {
                            Console.WriteLine(somePath3D.path[i].ToString());
                        }
                        IsValidCommand = true;
                        break;
                    }
                    case ConsoleKey.N:
                    {
                        Console.Clear();
                        Console.WriteLine("You have chosen to create your own path and save it to a file !");
                        Console.WriteLine("Press any key to continue !");
                        Console.ReadKey();
                        string[] input = new string[3];
                        while(true)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter \"end\" to finish ! Or press enter to continue !");
                            input[0] = Console.ReadLine();
                            if (input[0] == "end") break;
                            Console.Write("Enter Point's X - ");
                            input[0] = Console.ReadLine();
                            Console.Write("Enter Point's Y - ");
                            input[1] = Console.ReadLine();
                            Console.Write("Enter Point's Z - ");
                            input[2] = Console.ReadLine();
                            somePath3D.path.Add(new Point(double.Parse(input[0]), double.Parse(input[1]),
                                double.Parse(input[2])));
                        }
                        Storage.SavePath(somePath3D);
                        Console.Clear();
                        Console.WriteLine("Your file is saved in the folder \"paths\" by the name \"UserMade\" !");
                        IsValidCommand = true;
                        break;
                    }
                } 
            }
        }
    }
}
