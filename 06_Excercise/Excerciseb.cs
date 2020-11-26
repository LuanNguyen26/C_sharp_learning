using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            int select;
            do 
            {
                Console.WriteLine("1/add Student \t 2/Exit \t Choose?: ");
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Student a = new Student();
                    a.Input();
                    student.Add(a);
                }
            } while (select != 2);

            Console.WriteLine("\nStudent List: \n");
            student.Sort(new NameComparer());
            foreach (Student x in student)
            {
                x.Output();
            }
        }
    }
}
