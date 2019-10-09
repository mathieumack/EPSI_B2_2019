using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_8_4
{
    class Addition : BaseOperation, IOperation
    {
        public Addition()
        {
            Operation = "+";
        }

        /// <summary>
        /// Additionne 2 valeurs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private double Additionner(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Lance la calculatrice
        /// </summary>
        public void Start()
        {
            double valA = ReadValue("Saisissez  la première valeur :");
            double valB = ReadValue("Saisissez  la seconde valeur :");
            double total = Additionner(valA, valB);
            Console.WriteLine("Total : " + total);
        }
    }
}
