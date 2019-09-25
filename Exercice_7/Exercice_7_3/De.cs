using System;

namespace Exercice_7_3
{
    public class De
    {
        private Random Random { get; set; }

        public De()
        {
            Random = new Random();
        }

        public int Lancer()
        {
            return Lancer(1, 5);
        }

        public int Lancer(int min, int max)
        {
            return Random.Next(min, max);
        }
    }
}
