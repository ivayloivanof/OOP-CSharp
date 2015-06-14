namespace GalacticGPS
{
    using System;
    using Class;

    public class TestProgram
    {
        public static void Main()
        {
            try
            {
                Location home = new Location(18.037986, 28.870097, Planet.Earth);
                Console.WriteLine(home);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
