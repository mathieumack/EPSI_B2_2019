using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_8_4
{
    public class CalculatriceGenerique
    {
        public List<ICalculatrice> operations { get; set; }

        public CalculatriceGenerique()
        {
            operations = new List<ICalculatrice>();
            operations.Add(new CalculatriceInt());
            operations.Add(new CalculatriceSoustractionInt());
            operations.Add(new CalculatriceDivision());
        }

        public void Start()
        {
            string operation = ReadString("Saisissez  l'opération :");

            ICalculatrice operationAExecuter = null;
            for(int i = 0; i < operations.Count; i++)
            {
                if (operations[i].Operation == operation)
                    operationAExecuter = operations[i];
            }

            operationAExecuter.Start();
        }

        /// <summary>
        /// Lit une valeur dans la console et la transforme en valuer entière
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public string ReadString(string label)
        {
            Console.WriteLine(label);
            return Console.ReadLine();
        }
    }
}
