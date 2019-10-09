using System;

namespace Exercice_8_4
{
    public abstract class BaseOperation
    {
        public string Operation { get; protected set; }

        /// <summary>
        /// Lit une valeur dans la console et la transforme en valuer entière
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        protected int ReadValue(string label)
        {
            Console.WriteLine(label);
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
    }
}
