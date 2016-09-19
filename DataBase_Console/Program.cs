using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
            Student[] studentCollection = {  new Student(1, "Jones", 3.1),
                                new Student(2, "Kimball", 2.9),
                                new Student(5, "Oliver", 2.6),
                                new Student(6, "Mitchell", 3.0),
                                new Student(8, "Lee", 4.0),
                                new Student(10, "Cooper", 3.5)
                            };
            const int CUTOFF = 3;
            //Below is LINQ that is .NET code to query databases, as well as arrays or XML etc etc. = Langusge INtegrated Query
            //Assign result of query to that var w becomes implicitly-types collection.
            var goodStuCollection =
                from eachItem in studentCollection
                where eachItem.GradePointAverage > CUTOFF
                select eachItem; //LINQ should end e select or group by. So orderby goes before eithor of these
            Console.WriteLine("Stud with GPA >" + CUTOFF);
            foreach(var anItem in goodStuCollection)
            {
                Console.WriteLine("{0,3} {1,-8} {2,5}", anItem.IdNumber, anItem.Name, anItem.GradePointAverage.ToString("F1"));
            }
            //var highNum =
            //    from x in num
            //    where x > CUTOFF
            //    select x;
            //foreach(var n in highNum)
            //{
            //    Console.Write("{0}, ", n);
            //}
            Console.WriteLine();
        }
    }

    class Student
    {
        public Student(int num, string name, double avg)
        {
            IdNumber = num;
            Name = name;
            GradePointAverage = avg;
        }
        public int IdNumber { get; set; }
        public string Name { get; set; }
        public double GradePointAverage { get; set; }

    }
}
