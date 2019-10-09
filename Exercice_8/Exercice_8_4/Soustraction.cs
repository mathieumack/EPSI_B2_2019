using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_8_4
{
    class Soustraction : BaseOperation, IOperation
    {
        public Soustraction()
        {
            Operation = "-";
        }

        /// <summary>
        /// Soustrait 2 valeurs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int Soustraire(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Lance la calculatrice
        /// </summary>
        public void Start()
        {
            int valA = ReadValue("Saisissez  la première valeur :");
            int valB = ReadValue("Saisissez  la seconde valeur :");
            int total = Soustraire(valA, valB);
            Console.WriteLine("Total : " + total);
        }
    }
}
