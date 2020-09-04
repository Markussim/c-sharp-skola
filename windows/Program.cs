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

            int ageBefore = 2020 - int.Parse(yearBorn);

            int ageAfter = 0;

            for(var i = 0; i < ageBefore; i++) { // Detta är mycket dålig kod
                ageAfter++;
            }

            if(ageAfter > 0) {
                Console.WriteLine("You are " + ageAfter + " years old");
            } else {
                Console.WriteLine("You are dead");
            }

            switch(name) {
                case "Markus":
                    Console.WriteLine("Your name is McFänFän");
                    break;
                case "Linus":
                    Console.WriteLine("Your name is McAntAnt");
                    break;
                default:
                    while(name.Length < 60) {
                        name = name + name.Substring(name.Length - 1);
                    }
                    Console.WriteLine("Your name is " + name);
                    break;
            }

            
            
        }
    }
}
