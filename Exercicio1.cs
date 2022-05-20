using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosLógica
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int choice = 0;
            int attempts = 0;
            int rand = random.Next(11);
            Console.WriteLine("-----> " + rand + " <-----");

            do
            {
                Console.WriteLine("Choose a number: ");
                choice = int.Parse(Console.ReadLine());
                if (rand < choice)
                {
                    Console.WriteLine("Error! The number is less than: " + choice);
                }
                else if(rand > choice)
                {
                    Console.WriteLine("Error! The number is greather than: " + choice);
                }
                attempts++;
            } while (choice != rand);
                Console.WriteLine("Right in the bull's-eye! The number is: " + rand);
                Console.WriteLine("Attemps: " + attempts);

            Console.ReadLine();
        }
    }
}
