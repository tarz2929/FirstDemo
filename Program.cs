using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
                                  
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your name and age ");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name + " you are" + age + "years old.");

        }
    }
}
