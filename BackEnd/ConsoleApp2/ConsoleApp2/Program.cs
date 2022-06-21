using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    //Please output the students' names between the ages of 13 & 19 using LINQ.
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var ageList=studentList.Where(x => x.Age >= 13 & x.Age <= 19).Select(x=>x.StudentName);

            foreach(var item in ageList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
