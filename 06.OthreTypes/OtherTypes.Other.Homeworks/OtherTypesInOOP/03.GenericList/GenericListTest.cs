namespace _03.GenericList
{
    using System;

    class GenericListTest
    {
        static void Main()
        {
            GenericList<int> ints = new GenericList<int>();
            ints.Add(45);
            ints.Add(23);
            ints.Add(12);
            ints.InsertAt(3, 12);

            Console.WriteLine(GenericList<int>.Min(ints));
            Console.WriteLine(GenericList<int>.Max(ints));
            Console.WriteLine(ints.Contains(4));
            Console.WriteLine(ints.IndexOf(12));
            Console.WriteLine(ints);
            Console.WriteLine(GenericList<int>.Min(ints));
            Console.WriteLine(GenericList<int>.Max(ints));
            
            ints.RemoveAt(1);
            Console.WriteLine(ints);
            ints.Clear();

            System.Reflection.MemberInfo info = typeof(GenericList<>);
            foreach (object attribute in info.GetCustomAttributes(false))
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
