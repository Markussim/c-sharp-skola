using System;

namespace windows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year where you born?");

            string yearBorn = Console.ReadLine();

            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            int age = 2020 - int.Parse(yearBorn);

            if(age > 0) {
                Console.WriteLine("You are " + age + " years old");
            } else {
                Console.WriteLine("You are dead");
            }

            Console.WriteLine("Your name is " + name);
            
        }
    }
}
