using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_9_2
{
    public class CiseauxAction : BaseAction, IActionComparateur
    {
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
