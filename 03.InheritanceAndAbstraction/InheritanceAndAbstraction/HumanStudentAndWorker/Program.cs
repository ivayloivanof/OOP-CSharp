using System;
using System.Collections.Generic;

namespace HumanStudentAndWorker
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>
            {
                "Ivan Ivanov",
                "Asen Dimitrov",
                "Qsen Avramov",
                "Dimcho Dimitrov",
                "Rosen Avramov",
                "Qvor Dachkov",
                "Georgi Uzunov",
                "Mariq Qsenova",
                "Galq Avramova",
                "Kremena Paunova"
            };

            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();
            try
            {
                //create students
                for (int i = 0; i < names.Count; i++)
                {
                    string[] stud = names[i].Split();
                    Student student = new Student(stud[0], stud[1], i + 1);
                    students.Add(student);
                }

                //create workers
                for (int i = 0; i < names.Count; i++)
                {
                    string[] work = names[i].Split();
                    Worker worker = new Worker(work[0], work[1], 8);
                    workers.Add(worker);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Console.WriteLine();
        }
    }
}
