using System;
using System.Collections.Generic;
using System.Serialization;

namespace Console1
{
    class Program
    {
        interface IAnimal
        {
            public DateTime BirthDate();
            public void Move() { }
            public void Speak() { }
        }
		
		public class Pet : IAnimal
        {
            public void Move() { }
            public void Speak() { }
            public DateTime BirthDate()
            {
                throw new NotImplementedException();
            }
            public string Name { get; set; }
        }
		
        class Monkey : IAnimal
        {
            public DateTime BirthDate()
            {
                throw new NotImplementedException();
            }
            public void Move()
            {
                Console.WriteLine(" move with 2 hands");
            }
            public void Speak()
            {
                Console.WriteLine(" speak kec kec kec");
            }
            public void Climb()
            {
                Console.WriteLine("fast climb tree");
            }
        }
        class Cat : Pet
        {
            public void jump()
            {
                Console.Write(" jump very hight");
            }
            public void Move()
            {
                Console.Write(" move crawl move crawl");
            }
            public void Speak()
            {
                Console.Write(" speak meo meo meo");
            }
        }
        class Dog : Pet
        {
            public string Color { get; set; }
            public void Move()
            {
                Console.Write(" move run move run");
            }
            public void Speak()
            {
                Console.Write(" speak gau gau gau");
            }
        }
		
        static void Main(string[] args)
        {
            List<IAnimal> Animals = new List<IAnimal>();
            Console.Write("choose number of animals: ");
            int n = int.Parse(Console.ReadLine());
            int c;
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("1/Dog 2/Cat 3/Monkey \n What kind of animals you favourite : ");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Animals.Add(new Dog()); break;
                    case 2:
                        Animals.Add(new Cat()); break;
                    case 3:
                        Animals.Add(new Monkey()); break;
                }
            }
                     for (int i=0; i<n; i++)
                      {
                          Console.WriteLine("Con : " + (i+1));
                          Animals[i].Move();
                          Animals[i].Speak();
                      }
        }
    }
}