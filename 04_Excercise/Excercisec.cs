using System;
using System.C.G;
using 04_Generic.Model;
using 04_Generic.Repository;

namespace 04_Generic
{
    class Program
    {
        private static List<Student> rm_students = new List<Student>();
        private static List<Class> rm_classes = new List<Class>();
        static void Main(string[] args)
        {

            IRepository<Student> std = new BRepository<Student>(rm_students);
            IRepository<Class> clss = new BRepository<Class>(rm_classes);

            clss.Add(new Class("18DTHQA1"));
            clss.Add(new Class("18DTHQA2"));

            std.Add(new Student("NguyenVanA", 11));
            std.Add(new Student("DaoThiB", 22));
            std.Add(new Student("LamVanC", 33));
            std.Add(new Student("DoTienD", 44));

            Console.WriteLine("List Of classes:");

            foreach(var Clss in clss.GetAll())
            {
                Console.WriteLine(Clss.Name);
            }
			
            Console.WriteLine("List Of Students:");
			
            foreach(var Std in std.GetAll())
            {
               Console.WriteLine(Std.Name);
            }
        }
    }
}
