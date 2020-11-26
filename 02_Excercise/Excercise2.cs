using System;

namespace 02_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a: ");
            int a = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b, subtract = a - b, multiply = a * b;
            double divide = a / b;
            Console.WriteLine($" sum {a} + {b} = {sum}" );
            Console.WriteLine($" subtract {a} - {b} = {subtract}");
            Console.WriteLine($" multiply {a} * {b} = {multiply}");
            Console.WriteLine($" divide {a} / {b} = {divide}");

        }
    }
    
}
