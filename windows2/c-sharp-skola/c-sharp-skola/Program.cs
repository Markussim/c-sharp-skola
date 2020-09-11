using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace windows
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for(var i = 1; i <= 5; i++)
            {
                Console.WriteLine("Namn " +  i + ":");
                names[i - 1] = Console.ReadLine();
            }

            Array.Reverse(names);

            var jsonString = JsonSerializer.Serialize(names);

            Console.WriteLine(jsonString);

        }
    }
}
