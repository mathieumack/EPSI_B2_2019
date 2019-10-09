using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_8_4
{
    public class CalculatriceGenerique
    {
        public List<IOperation> operations { get; set; }

        public CalculatriceGenerique()
        {
            operations = new List<IOperation>();
            operations.Add(new Addition());
            operations.Add(new Soustraction());
            operations.Add(new Division());
        }

        public void Start()
        {
            string operation = ReadString("Saisissez  l'opération :");

            IOperation operationAExecuter =
                operations.FirstOrDefault(elementCourant => elementCourant.Operation == operation);

            if(operationAExecuter != null)
                operationAExecuter.Start();
            else
                Console.WriteLine("Opération non trouvée");
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
