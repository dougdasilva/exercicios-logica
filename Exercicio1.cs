using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosLógica
{
    internal class Exercicio1
    {
        /*
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
                else if (rand > choice)
                {
                    Console.WriteLine("Error! The number is greather than: " + choice);
                }
                attempts++;
            } while (choice != rand);
            Console.WriteLine("Right in the bull's-eye! The number is: " + rand);
            Console.WriteLine("Attemps: " + attempts);

            Console.ReadLine();
        }*/
        /*static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            double[] tests = new double[2];

            for (int i = 0; i < tests.Length; i++)
            {
                Console.WriteLine($"Test #{i+1}: ");
                tests[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            foreach (var item in tests)
            {
                sum += item;
            }
            double avg = sum / tests.Count();

            if (avg >= 6.0)
            {
                Console.WriteLine("Aprovado com média " + avg);
            }
            else
            {
                Console.WriteLine("REPROVADO! Você tirou nota " + avg);
            }
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número total de eleitores: ");
            int eleitores = int.Parse(Console.ReadLine());
            int candidatoa = 0;
            int candidatob = 0;
            int candidatoc = 0;
            int votantes = 0;
            while (votantes < eleitores)
            {
                Console.WriteLine("Digite 1, 2 ou 3: ");
                int voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    candidatoa = candidatoa + 1;
                }
                else if (voto == 2)
                {
                    candidatob = candidatob + 1;
                }
                else if (voto == 3)
                {
                    candidatoc = candidatoc + 1;
                }
                else
                {
                    Console.WriteLine("Nulo");
                }
                votantes = votantes + 1;
            }

            Console.WriteLine("O candidato A teve " + candidatoa + " votos.");
            Console.WriteLine("O candidato B teve " + candidatob + " votos.");
            Console.WriteLine("O candidato C teve " + candidatoc + " votos.");

            if (candidatoa > candidatob && candidatoa > candidatoc)
            {
                Console.WriteLine("Ganhador A com " + candidatoa + " votos");
              
            }
            else if (candidatob > candidatoc && candidatob > candidatoa)
            {
                Console.WriteLine("Ganhador B com " + candidatob + " votos");
            }
            else
            {
                Console.WriteLine("Ganhador C com " + candidatoc + " votos");
            }

        }
    }
}