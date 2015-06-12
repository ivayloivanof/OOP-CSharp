using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human_Student_and_Worker;

namespace Human_Student_Worker
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Student> students=new List<Student>();
           Student pesho = new Student("Pesho", "Georgiev", "00004");
           students.Add(pesho);
           Student gosho = new Student("Gosho", "Djambazov", "00003");
           Student aleks = new Student("Aleks", "Dimitrov", "00001");
           Student dimitur = new Student("Mitko", "Petrov", "00002");
           Student marin = new Student("Marin", "Grublev", "00005");
            students.Add(gosho);
            students.Add(aleks);
            students.Add(dimitur);
            students.Add(marin);
            var order =
                from student in students
                orderby student.FacultyNumber
                select student;
            foreach (var s in order)
            {
                Console.WriteLine(s.FirstName+" "+s.LastName+" "+s.FacultyNumber);
            }
            Console.WriteLine();
            List<Worker> workers=new List<Worker>();
            Worker peshoW=new Worker("Pesho","Peshev",200,37);
            Worker goshoW = new Worker("Gosho", "Goshev", 174, 39);
            Worker marinW = new Worker("Marin", "Grublev", 100, 45);
            Worker deanW=new Worker("Dean","Bojinov",154,40);
            Worker mitkoW = new Worker("Mitko", "Rusev", 300, 20);
            workers.Add(peshoW);
            workers.Add(goshoW);
            workers.Add(marinW);
            workers.Add(deanW);
            workers.Add(mitkoW);
            var orderW =
                from worker in workers
                orderby worker.MoneyPerHour()
                select worker;
            foreach (var worker in orderW)
            {
                Console.WriteLine("{0} {1} {2:f2}",worker.FirstName,worker.LastName,worker.MoneyPerHour());
            }
        }
    }
}
