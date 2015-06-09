namespace BookStore.UI
{
    using Interfaces;
    using System;

    public class ConsoleUI : IReadeble, IRenderer
    {

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string str, decimal? num = null)
        {
            //("Total revenue: {0:F2}", this.revenue)
            if (str.Contains("Total"))
            {
                Console.WriteLine("Total revenue: {0:F2}", num);
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
