using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Human_Student_and_Worker
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Penkov", "150203"),
                new Student("Maria","Petrova","091234"),
                new Student("Gosho","Goshev","142345"),
                new Student("Gergan","Kolev","146789"),
                new Student("Silvia","Petrova","144321"),
                new Student("Lilia","Marinova","152345"),
                new Student("Mladen","Iliev","031234"),
                new Student("Iliyan","Krasimirov","132345"),
                new Student("Petyr","Petrov","021234"),
                new Student("Gosho","Georgiev","146780")
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan","Ivanov",500.32,8),
                new Worker("Petar","Mladenov",473.21,8),
                new Worker("Sasha","Ivanovich",1023.12,8),
                new Worker("Maria","Vasileva",543.13,8),
                new Worker("Radost","Radostinova",200,4),
                new Worker("Stiliyan","Gornachkov",1001.21,10),
                new Worker("Delyan","Radev",777,7),
                new Worker("Ivaylo","zashev",1032,8),
                new Worker("Ekaterina","Pamukova",600,8),
                new Worker("Emil","Stoyanov",2000,12)
            };
            var sortedList = students.OrderBy(facNumber => facNumber.Facultynumber);
            foreach (var student in sortedList)
            {
                Console.WriteLine("{0} {1} {2}",student.Facultynumber,student.Firstname,student.Lastname);
            }

            var workerSortedList = workers.OrderByDescending(moneyPerHour => moneyPerHour.MoneyPerHour());
            Console.WriteLine();
            foreach (var worker in workerSortedList)
            {
                Console.WriteLine("{0} {1} {2:F2} money per hour", worker.Firstname, worker.Lastname,worker.MoneyPerHour());
            }

        }
    }
}
