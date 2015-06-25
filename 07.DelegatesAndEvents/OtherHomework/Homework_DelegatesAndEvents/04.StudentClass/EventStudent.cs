using System;

namespace StudentClass
{
    public class EventStudent
    {
        public static void Main()
        {
            try
            {
                Student student = new Student("Peter", 22);

                student.PropertyChanged += (sender, eventArgs) =>
                {
                    Console.WriteLine("Propery changed: {0} (from {1} to {2})",
                        eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
                };

                student.Name = "Maria";
                student.Age = 19;
            }

            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}