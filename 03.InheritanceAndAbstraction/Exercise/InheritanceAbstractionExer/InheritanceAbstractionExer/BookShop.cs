using System;

class BookShop
{
    static void Main()
    {
        try
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.60m);
            Console.WriteLine(book);

            GoldenBookEdition goldenBook = new GoldenBookEdition("Tutun", "Dimitur Talev", 22.90m);
            Console.WriteLine(goldenBook);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }
}
