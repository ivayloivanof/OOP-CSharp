using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
                Dictionary<int, object> all = new Dictionary<int, object>();
                //create students
                for (int i = 0; i < names.Count; i++)
                {
                    string[] stud = names[i].Split();
                    Student student = new Student(stud[0], stud[1], i + 1);
                    students.Add(student);
                    all.Add(i, student);
                }
                //create workers
                for (int i = 0; i < names.Count; i++)
                {
                    string[] work = names[i].Split();
                    Worker worker = new Worker(work[0], work[1], 8);
                    workers.Add(worker);
                    all.Add(names.Count+i, worker);
                }

                var ascendingStudent = from data in students
                    orderby data.FacultyNumber ascending
                    select data;

                var descendingWorker = from work in workers
                    orderby work.PayPerHour
                    select work;

                //linq order by first name query add here

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
