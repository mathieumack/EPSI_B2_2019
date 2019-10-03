using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_2
{
    public interface IActionComparateur
    {
        Action ActionDefinition { get; }

        /// <summary>
        /// Renvoie vrai si ActionDefinition gagne sur l'action envoyée en paramètre
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        bool Gagne(Action action);
    }
}
