using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_8_4
{
    class Division : BaseOperation, IOperation
    {
        public Division()
        {
            Operation = "/";
        }

        /// <summary>
        /// Additionne 2 valeurs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int Diviser(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Lance la calculatrice
        /// </summary>
        public void Start()
        {
            int valA = ReadValue("Saisissez  la première valeur :");
            int valB = ReadValue("Saisissez  la seconde valeur :");
            int total = Diviser(valA, valB);
            Console.WriteLine("Total : " + total);
        }
    }
}
