using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_8_4
{
    public interface IOperation
    {
        /// <summary>
        /// +, -, ...
        /// </summary>
        string Operation { get; }

        /// <summary>
        /// Lance le calcul pour l'opération donnée
        /// </summary>
        void Start();
    }
}
