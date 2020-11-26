using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exercise6
{
    class Student : IComparable<Student>
    {
        public string Name;
        public string StudentID;
        public Student(){}
        public string name 
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string ID
        {
            get
            {
                return StudentID;
            }
            set
            {
                StudentID = value;
            }
        }
        public void Input()
        {
            Console.Write("Input student name: ");
            Name = Console.ReadLine();
            Console.Write("Input Student id: ");
            StudentID = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"{Name} - {StudentID}");
        }
        public int CompareTo(Student other)
        {
            return this.StudentID.CompareTo(other.StudentID);
        }
        public int CompareTo1(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }

    class NameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
