using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_1
{
    public class CiseauxAction : IActionComparateur
    {
        public Action ActionDefinition { get; private set; }

        public CiseauxAction()
        {
            ActionDefinition = Action.Ciseaux;
        }

        public bool Gagne(Action action)
        {
            return action == Action.Feuille;
        }
    }
}
