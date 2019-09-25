using System;

namespace Exercice_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomValue = random.Next(0, 1001);

            Console.WriteLine("Entrez une valeur :");
            string userValue = Console.ReadLine();
            int value = int.Parse(userValue);

            while (value != randomValue)
            {
                if (value < randomValue)
                    Console.WriteLine("C'est +");
                else
                    Console.WriteLine("C'est -");

                Console.WriteLine("Entrez une nouvelle valeur :");
                userValue = Console.ReadLine();
                value = int.Parse(userValue);
            }

            Console.WriteLine("Trouvé !");
        }
    }
}
