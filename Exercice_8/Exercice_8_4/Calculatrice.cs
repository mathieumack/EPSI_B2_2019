using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_8_4
{
    public class Calculatrice
    {
        /// <summary>
        /// Additionne 2 valeurs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int Additionne(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Additionne 2 valeurs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private double Additionne(double a, double b)
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
            double total = Additionne(valA, valB);
            Console.WriteLine("Total : " + total);
        }

        /// <summary>
        /// Lit une valeur dans la console et la transforme en valuer entière
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public int ReadValue(string label)
        {
            Console.WriteLine(label);
            return int.Parse(Console.ReadLine());
        }
    }
}
