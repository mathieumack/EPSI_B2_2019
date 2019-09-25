using System;

namespace Exercice_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreEssais = 15;

            Random random = new Random();
            int randomValue = random.Next(0, 1001);

            Console.WriteLine("Entrez une valeur :");
            string userValue = Console.ReadLine();
            int value = int.Parse(userValue);

            while (nombreEssais > 0 && value != randomValue)
            {
                if (value < randomValue)
                    Console.WriteLine("C'est +");
                else
                    Console.WriteLine("C'est -");

                Console.WriteLine("Entrez une nouvelle valeur :");
                userValue = Console.ReadLine();
                value = int.Parse(userValue);

                nombreEssais--;
            }

            if (value != randomValue)
                Console.WriteLine("Vous avez épuisé le nombre de tentatives !");
            else
                Console.WriteLine("Trouvé !");
        }
    }
}
