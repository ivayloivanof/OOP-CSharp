using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Human_Student_and_Worker
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Anton", "Petrov", "345nbv241"),
                new Student("Ivan", "Ivanov", "123asd789"),
                new Student("Petar", "Petrov", "124bvc790"),
                new Student("Georgi", "Georgiev", "345qwe078"),
                new Student("Hristo", "Kirilov", "223axg120"),
                new Student("Evgeny", "Evgeniev", "145tre954"),
                new Student("Boris", "Borisov", "453hgf070"),
                new Student("Ivan", "Cvetanov", "127ptr907"),
                new Student("Damian", "Damianov", "349cxz881"),
                new Student("Ivan", "Filipov", "458wsa456")
            };

            var sortedStudents = from student in students orderby student.FacultyNumber ascending select student;

            Console.WriteLine("The students...");
            foreach (var stud in sortedStudents)
            {
                Console.WriteLine(stud);
            }
            
            Console.WriteLine("\nNow the workers...");
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Anton", "Antonov", 123, 12),
                new Worker("Ivan", "Petkov", 150.45, 10),
                new Worker("Petar", "Hristov", 90, 4),
                new Worker("Hristo", "Georgiev", 200, 12),
                new Worker("Hristo", "Hristov", 78, 6.5),
                new Worker("Evgeny", "Haralampiev", 45.59, 4.25),
                new Worker("Boris", "Andonov", 100, 8),
                new Worker("Cvetan", "Cvetanov", 95, 7.5),
                new Worker("Hristo", "Damianov", 55, 5.5),
                new Worker("Filip", "Filipov", 40, 4),
            };

            var sortedWorkers = from worker in workers orderby worker.MoneyPerHour() descending select worker;
            foreach (var work in sortedWorkers)
            {
                Console.WriteLine(work);
            }

            List<Human> allPeople = new List<Human>();
            allPeople.AddRange(students);
            allPeople.AddRange(workers);

            var sortedPeople = from person in allPeople orderby person.FirstName, person.LastName select person;
            Console.WriteLine("\nAnd now all the people...");
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}